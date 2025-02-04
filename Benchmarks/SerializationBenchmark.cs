using BenchmarkDotNet.Attributes;
using MessagePack;
using Newtonsoft.Json;
using JsonBenchmarks.Models;

namespace JsonBenchmarks.Benchmarks
{
    [MemoryDiagnoser]
    public class SerializationBenchmark
    {
        [Params(10, 20, 30)]
        public int ProductCount;

        private List<Product> products;

        [GlobalSetup]
        public void Setup()
        {
            products = [];
            for (int i = 0; i < ProductCount; i++)
            {
                products.Add(new Product
                {
                    Id = i,
                    Name = $"Smartphone XYZ Ultra Max Pro {i}",
                    Category = "Electronics",
                    Variants =
                    [
                        new Variant
                        {
                            VariantId = i + 1,
                            Size = "64GB Storage",
                            Stocks =
                            [
                                new Stock { WarehouseId = 101, Quantity = 100, LastUpdated = DateTime.UtcNow },
                                new Stock { WarehouseId = 102, Quantity = 80, LastUpdated = DateTime.UtcNow.AddDays(-i) }
                            ],
                            Prices =
                            [
                                new Price { Currency = "USD", Amount = 699.99m, LastUpdated = DateTime.UtcNow },
                                new Price { Currency = "EUR", Amount = 649.99m, LastUpdated = DateTime.UtcNow.AddDays(-i) }
                            ]
                        },
                        new Variant
                        {
                            VariantId = i + 2,
                            Size = "128GB Storage",
                            Stocks =
                            [
                                new Stock { WarehouseId = 103, Quantity = 50, LastUpdated = DateTime.UtcNow },
                                new Stock { WarehouseId = 104, Quantity = 40, LastUpdated = DateTime.UtcNow.AddDays(-i) }
                            ],
                            Prices =
                            [
                                new Price { Currency = "USD", Amount = 799.99m, LastUpdated = DateTime.UtcNow },
                                new Price { Currency = "EUR", Amount = 749.99m, LastUpdated = DateTime.UtcNow.AddDays(-i) }
                            ]
                        },
                        new Variant
                        {
                            VariantId = i + 3,
                            Size = "256GB Storage",
                            Stocks =
                            [
                                new Stock { WarehouseId = 105, Quantity = 30, LastUpdated = DateTime.UtcNow },
                                new Stock { WarehouseId = 106, Quantity = 20, LastUpdated = DateTime.UtcNow.AddDays(-i) }
                            ],
                            Prices =
                            [
                                new Price { Currency = "USD", Amount = 899.99m, LastUpdated = DateTime.UtcNow },
                                new Price { Currency = "EUR", Amount = 849.99m, LastUpdated = DateTime.UtcNow.AddDays(-i) }
                            ]
                        }
                    ]
                });
            }
        }

        [Benchmark]
        public byte[] SerializeWithMessagePack()
        {
            return MessagePackSerializer.Serialize(products);
        }

        [Benchmark]
        public string SerializeWithNewtonsoftJson()
        {
            return JsonConvert.SerializeObject(products);
        }

        [Benchmark]
        public string SerializeWithSystemTextJson()
        {
            return System.Text.Json.JsonSerializer.Serialize(products);
        }

        [Benchmark]
        public List<Product> DeserializeWithMessagePack()
        {
            var bytes = MessagePackSerializer.Serialize(products);
            return MessagePackSerializer.Deserialize<List<Product>>(bytes);
        }

        [Benchmark]
        public List<Product> DeserializeWithNewtonsoftJson()
        {
            var json = JsonConvert.SerializeObject(products);
            return JsonConvert.DeserializeObject<List<Product>>(json)!;
        }

        [Benchmark]
        public List<Product> DeserializeWithSystemTextJson()
        {
            var json = System.Text.Json.JsonSerializer.Serialize(products);
            return System.Text.Json.JsonSerializer.Deserialize<List<Product>>(json)!;
        }
    }
}