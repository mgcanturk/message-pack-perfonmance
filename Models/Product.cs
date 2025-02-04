using System;
using System.Collections.Generic;
using MessagePack;

namespace JsonBenchmarks.Models
{
    [MessagePackObject]
    public class Product
    {
        [Key("id")]
        public int Id { get; set; }
        [Key("name")]
        public string Name { get; set; }
        [Key("category")]
        public string Category { get; set; }
        [Key("variants")]
        public List<Variant> Variants { get; set; }
    }
}