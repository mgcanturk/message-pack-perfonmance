using System;
using MessagePack;

namespace JsonBenchmarks.Models
{
    [MessagePackObject]
    public class Stock
    {
        [Key("warehouseId")]
        public int WarehouseId { get; set; }
        [Key("quantity")]
        public int Quantity { get; set; }
        [Key("lastUpdated")]
        public DateTime LastUpdated { get; set; }
    }
}