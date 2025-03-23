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
        private byte[] serializedMessagePack;
        private string serializedNewtonsoftJson;
        private string serializedSystemTextJson;

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

            // Ön işleme ile serialize edilen verileri hazırlayalım
            serializedMessagePack = MessagePackSerializer.Serialize(products);
            serializedNewtonsoftJson = JsonConvert.SerializeObject(products);
            serializedSystemTextJson = System.Text.Json.JsonSerializer.Serialize(products);
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
            return MessagePackSerializer.Deserialize<List<Product>>(serializedMessagePack);
        }

        [Benchmark]
        public List<Product> DeserializeWithNewtonsoftJson()
        {
            return JsonConvert.DeserializeObject<List<Product>>(serializedNewtonsoftJson)!;
        }

        [Benchmark]
        public List<Product> DeserializeWithSystemTextJson()
        {
            return System.Text.Json.JsonSerializer.Deserialize<List<Product>>(serializedSystemTextJson)!;
        }
    }
}