using BenchmarkDotNet.Running;
using JsonBenchmarks.Benchmarks;

var summary = BenchmarkRunner.Run<SerializationBenchmark>();