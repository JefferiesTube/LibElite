using LibElite.PilotJournal.Converter;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace LibElite.PilotJournal.Events.FleetCarriers
{
    /// <summary>
    /// The carrier owner has requested the carrier buys or sells goods (or cancels such an order)
    /// </summary>
    [EventType("CarrierTradeOrder")]
    public class CarrierTradeOrder : CarrierEventBase
    {
        [J("CarrierID")] public long CarrierID { get; set; }
        [J("BlackMarket")] public bool BlackMarket { get; set; }
        [J("Commodity")] public string Commodity { get; set; }
        [J("Commodity_Localised")] public string CommodityLocalised { get; set; }
        [J("PurchaseOrder")] public long PurchaseOrder { get; set; }
        [J("SaleOrder")] public long SaleOrder { get; set; }
        [J("CancelTrade")] public bool CancelTrade { get; set; }
        [J("Price")] public long Price { get; set; }
    }
}