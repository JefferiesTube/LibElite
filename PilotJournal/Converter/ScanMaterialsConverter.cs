using LibElite.PilotJournal.Events.Exploration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LibElite.PilotJournal.Converter
{
    public class ScanMaterialsConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Dictionary<string, double>);

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            if (reader.TokenType == JsonToken.StartArray)
            {
                return serializer.Deserialize<MaterialComposition[]>(reader);
            }
            Dictionary<string, double> x = serializer.Deserialize<Dictionary<string, double>>(reader);
            List<MaterialComposition> compositions = new List<MaterialComposition>();
            foreach (KeyValuePair<string, double> pair in x)
            {
                compositions.Add(new MaterialComposition() { Name = pair.Key, Name_Localised = pair.Key, Percent = pair.Value });
            }

            return compositions.ToArray();
        }
    }
}