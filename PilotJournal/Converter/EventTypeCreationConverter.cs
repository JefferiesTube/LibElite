using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LibElite.PilotJournal.Converter
{
    public class EventTypeConverter : JsonConverter
    {
        private static readonly Regex _regex;

        private static readonly Dictionary<string, Type> _eventTypeMap;

        private static IEnumerable<Type> GetEnumerableOfType<T>() where T : class
        {
            List<Type> objects = new List<Type>();
            foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                objects.AddRange(assembly.GetTypes().Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(T))));
            }

            return objects;
        }

        static EventTypeConverter()
        {
            _regex = new Regex("\\\"event\\\":\\\"([\\w\\d]+)\\\"", RegexOptions.Compiled);
            _eventTypeMap = GetEnumerableOfType<EventBase>()
                .Select(t => new { Type = t, Attribute = t.GetCustomAttribute<EventTypeAttribute>() })
                .Where(data => data.Attribute != null)
                .ToDictionary(data => data.Attribute.Type, data => data.Type);
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(EventBase);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            
            string input = JRaw.Create(reader).ToString();
            string eventType = _regex.Match(input).Groups[1].Value;
            return serializer.Deserialize(reader, _eventTypeMap[eventType]);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class EventTypeAttribute : Attribute
    {
        public string Type { get; private set; }

        public EventTypeAttribute(string type)
        {
            Type = type;
        }

        public string GetTypeName()
        {
            return Type;
        }
    }

    //public abstract class JsonCreationConverter<T> : JsonConverter
    //{
    //    protected abstract T Create(Type objectType, JObject jsonObject);

    //    protected abstract Type GetTargetType(string typeIdentifier);

    //    public override bool CanConvert(Type objectType)
    //    {
    //        return typeof(T).IsAssignableFrom(objectType);
    //    }

    //    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    //    {
    //        JObject jsonObject;
    //        try
    //        {
    //            jsonObject = JObject.Load(reader);
    //        }
    //        catch(JsonReaderException)
    //        {
    //            return null;
    //        }
    //        //T target = Create(objectType, jsonObject);
    //        try
    //        {
    //            serializer.ContractResolver = new AttributedContractResolver();
    //            return jsonObject.ToObject(GetTargetType(jsonObject["event"].ToString()));
    //            // serializer.Populate(jsonObject.CreateReader(), target);
    //            //return target;
    //        }
    //        catch
    //        {
    //            return null;
    //        }
    //    }

    //    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    //    {
    //        if (writer.WriteState == WriteState.Property)
    //        {
    //            writer.WritePropertyName("event");
    //            serializer.Serialize(writer, value);
    //        }
    //    }
    //}

    //public class TypeAttributeCreationConverter<TBaseType, TAttribute> : JsonCreationConverter<TBaseType>
    //    where TBaseType : class
    //    where TAttribute : EventTypeAttribute
    //{
    //    private Dictionary<string, Type> typeMap = new Dictionary<string, Type>();

    //    public override bool CanConvert(Type objectType)
    //    {
    //        return objectType.GetAttribute<EventTypeAttribute>() != null;
    //    }

    //    protected override Type GetTargetType(string typeIdentifier)
    //    {
    //        if (typeMap.ContainsKey(typeIdentifier))
    //        {
    //            return typeMap[typeIdentifier];
    //        }

    //        try
    //        {
    //            Type targetType = ReflectionExtensions.GetEnumerableOfType<TBaseType>()
    //                .Select(t => new { Type = t, Attribute = t.GetAttribute<TAttribute>() })
    //                .Where(data => data.Attribute != null)
    //                .Single(data => data.Attribute.Type.Equals(typeIdentifier, StringComparison.InvariantCultureIgnoreCase)).Type;
    //            typeMap.Add(typeIdentifier, targetType);
    //            return targetType;
    //        }
    //        catch (InvalidOperationException)
    //        {
    //            return null;
    //        }
    //    }

    //    protected override TBaseType Create(Type objectType, JObject jsonObject)
    //    {
    //        string typeName = jsonObject["event"].ToString();
    //        if (typeMap.ContainsKey(typeName))
    //        {
    //            return (TBaseType)Activator.CreateInstance(typeMap[typeName]);
    //        }

    //        try
    //        {
    //            Type targetType = ReflectionExtensions.GetEnumerableOfType<TBaseType>()
    //                .Select(t => new {Type = t, Attribute = t.GetAttribute<TAttribute>()})
    //                .Where(data => data.Attribute != null)
    //                .Single(data => data.Attribute.Type.Equals(typeName)).Type;
    //            typeMap.Add(typeName, targetType);
    //            return (TBaseType)Activator.CreateInstance(targetType);
    //        }
    //        catch (InvalidOperationException)
    //        {
    //            typeMap.Add(typeName, objectType);
    //            return (TBaseType)Activator.CreateInstance(objectType);
    //        }
    //    }

    //    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    //    {
    //        writer.WriteStartObject();
    //        TAttribute t = ReflectionExtensions.GetEnumerableOfType<TBaseType>()
    //            .Select(ty => new
    //            {
    //                Type = ty,
    //                Attribute = ty.GetAttribute<TAttribute>()
    //            })
    //            .Where(data => data.Attribute != null && data.Type == value.GetType()).FirstOrDefault().Attribute;

    //        writer.WriteToken(JsonToken.PropertyName, "event");
    //        writer.WriteToken(JsonToken.String, t.GetTypeName());
    //        IEnumerable<PropertyInfo> props = value.GetType().GetProperties(
    //                BindingFlags.Instance | BindingFlags.Public)
    //            .Where(ø => ø.CanRead && ø.CanWrite)
    //            .Where(ø => ø.PropertyType == typeof(string));

    //        foreach (PropertyInfo info in props)
    //        {
    //            if (info.CanRead)
    //            {
    //                writer.WriteToken(JsonToken.PropertyName, info.Name);
    //                object propertyValue = info.GetValue(value, null);
    //                switch (propertyValue)
    //                {
    //                    case bool b:
    //                        writer.WriteToken(JsonToken.Boolean, b);
    //                        break;

    //                    case int i:
    //                        writer.WriteToken(JsonToken.Integer, i);
    //                        break;

    //                    case string s:
    //                        writer.WriteToken(JsonToken.String, s);
    //                        break;

    //                    default:
    //                        writer.WriteValue(propertyValue);
    //                        break;
    //                }
    //            }
    //        }

    //        writer.WriteEndObject();
    //        base.WriteJson(writer, value, serializer);
    //    }
    //}
}