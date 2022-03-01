using System;
using Ionic.Zlib;
using NetMQ;
using NetMQ.Sockets;
using System.Text;
using System.Threading;
using LibElite.EDDN.Schemes;
using Newtonsoft.Json.Linq;

namespace LibElite.EDDN
{
    public class EDDNListener
    {
        private readonly Thread _thread;
        private readonly SubscriberSocket _client;
        private readonly UTF8Encoding _encoding;

        public event Action<Journal> NewJournalMessage;
        public event Action<Commodity> NewCommodityMessage;
        public event Action<Shipyard> NewShipyardMessage;
        public event Action<Outfitting> NewOutfittingMessage;
        public event Action<Blackmarket> NewBlackmarketMessage;

        public EDDNListener()
        {
            _thread = new Thread(Listen);
            _client = new SubscriberSocket();
            _encoding = new UTF8Encoding();
        }

        public void Start()
        {
            _client.Options.ReceiveHighWatermark = 1000;
            _client.Connect("tcp://eddn.edcd.io:9500");
            _client.SubscribeToAnyTopic();
            _thread.Start();
        }

        private void Listen()
        {
            byte[] uncompressed = ZlibStream.UncompressBuffer(_client.ReceiveFrameBytes());
            string result = _encoding.GetString(uncompressed);
            JObject jo = JObject.Parse(result);
            string schema = jo["$schemaRef"].Value<string>();
            switch (schema)
            {
                case "https://eddn.edcd.io/schemas/journal/1":
                    NewJournalMessage?.Invoke(jo.ToObject<Journal>());
                    break;
                case "https://eddn.edcd.io/schemas/commodity/3":
                    try
                    {
                        NewCommodityMessage?.Invoke(jo.ToObject<Commodity>());
                    }
                    catch (Exception) { }
                    break;
                case "https://eddn.edcd.io/schemas/outfitting/2":
                    NewOutfittingMessage?.Invoke(jo.ToObject<Outfitting>());
                    break;
                case "https://eddn.edcd.io/schemas/blackmarket/1":
                    NewBlackmarketMessage?.Invoke(jo.ToObject<Blackmarket>());
                    break;
                case "https://eddn.edcd.io/schemas/shipyard/2":
                    NewShipyardMessage?.Invoke(jo.ToObject<Shipyard>());
                    break;
            }
        }
    }
}