using System;
using System.Collections.Generic;
using MessagePack;

namespace JsonBenchmarks.Models
{
     [MessagePackObject]
    public class Variant
    {
         [Key("variantId")]
        public int VariantId { get; set; }
         [Key("size")]
        public string Size { get; set; }
        [Key("stocks")]
        public List<Stock> Stocks { get; set; }
        [Key("prices")]
        public List<Price> Prices { get; set; }
    }
}