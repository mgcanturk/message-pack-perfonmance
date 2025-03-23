```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3476)
12th Gen Intel Core i7-1255U, 1 CPU, 12 logical and 10 physical cores
.NET SDK 9.0.101
  [Host]     : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2


```
| Method                        | ProductCount | Mean       | Error      | StdDev     | Median     | Gen0    | Gen1   | Allocated |
|------------------------------ |------------- |-----------:|-----------:|-----------:|-----------:|--------:|-------:|----------:|
| **SerializeWithMessagePack**      | **10**           |   **9.349 μs** |  **0.1796 μs** |  **0.2069 μs** |   **9.359 μs** |  **1.2512** |      **-** |   **7.73 KB** |
| SerializeWithNewtonsoftJson   | 10           |  42.109 μs |  0.6174 μs |  0.5775 μs |  42.121 μs | 11.4746 | 1.0986 |  70.73 KB |
| SerializeWithSystemTextJson   | 10           |  18.063 μs |  0.2041 μs |  0.1909 μs |  18.137 μs |  4.0283 |      - |   24.8 KB |
| DeserializeWithMessagePack    | 10           |  16.910 μs |  0.1844 μs |  0.1725 μs |  16.887 μs |  2.6550 | 0.1221 |   16.3 KB |
| DeserializeWithNewtonsoftJson | 10           |  63.591 μs |  1.2643 μs |  1.2984 μs |  63.674 μs |  5.0049 | 0.2441 |  30.94 KB |
| DeserializeWithSystemTextJson | 10           |  36.168 μs |  0.7205 μs |  0.7399 μs |  36.173 μs |  3.0518 | 0.1831 |  18.87 KB |
| **SerializeWithMessagePack**      | **20**           |  **17.412 μs** |  **0.2719 μs** |  **0.2410 μs** |  **17.431 μs** |  **2.5024** |      **-** |  **15.43 KB** |
| SerializeWithNewtonsoftJson   | 20           |  99.852 μs |  8.0762 μs | 23.8129 μs |  84.764 μs | 22.7051 | 3.7842 | 139.59 KB |
| SerializeWithSystemTextJson   | 20           |  38.128 μs |  0.6174 μs |  0.5775 μs |  38.226 μs |  7.9346 |      - |   48.8 KB |
| DeserializeWithMessagePack    | 20           |  32.955 μs |  0.3013 μs |  0.2516 μs |  32.907 μs |  5.3101 | 0.4883 |  32.55 KB |
| DeserializeWithNewtonsoftJson | 20           | 122.015 μs |  1.2851 μs |  1.2020 μs | 122.037 μs |  9.6436 | 1.0986 |  59.65 KB |
| DeserializeWithSystemTextJson | 20           |  69.794 μs |  1.0942 μs |  1.0235 μs |  69.662 μs |  5.8594 | 0.6104 |  36.33 KB |
| **SerializeWithMessagePack**      | **30**           |  **26.140 μs** |  **0.3920 μs** |  **0.3667 μs** |  **26.126 μs** |  **3.7537** |      **-** |  **23.13 KB** |
| SerializeWithNewtonsoftJson   | 30           | 143.224 μs | 12.5101 μs | 36.2940 μs | 123.712 μs | 31.0059 | 5.1270 |  192.8 KB |
| SerializeWithSystemTextJson   | 30           |  54.540 μs |  0.6525 μs |  0.5784 μs |  54.565 μs | 11.7188 |      - |  72.77 KB |
| DeserializeWithMessagePack    | 30           |  49.523 μs |  0.6957 μs |  0.6167 μs |  49.663 μs |  7.9346 | 1.0376 |   48.8 KB |
| DeserializeWithNewtonsoftJson | 30           | 188.147 μs |  2.3178 μs |  2.1681 μs | 188.987 μs | 14.1602 | 1.9531 |  88.09 KB |
| DeserializeWithSystemTextJson | 30           | 104.104 μs |  1.2349 μs |  1.1552 μs | 104.408 μs |  8.6670 | 1.2207 |  53.52 KB |
