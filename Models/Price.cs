using System;
using MessagePack;

namespace JsonBenchmarks.Models
{
    [MessagePackObject]
    public class Price
    {
        [Key("currency")]
        public string Currency { get; set; }
        [Key("amount")]
        public decimal Amount { get; set; }
        [Key("lastUpdated")]
        public DateTime LastUpdated { get; set; }
    }
}