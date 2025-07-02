```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3476)
12th Gen Intel Core i7-1255U, 1 CPU, 12 logical and 10 physical cores
.NET SDK 9.0.101
  [Host]     : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2


```
| Method                        | ProductCount | Mean       | Error      | StdDev     | Median     | Gen0    | Gen1   | Allocated |
|------------------------------ |------------- |-----------:|-----------:|-----------:|-----------:|--------:|-------:|----------:|
| **SerializeWithMessagePack**      | **10**           |   **9.082 μs** |  **0.1725 μs** |  **0.1987 μs** |   **9.069 μs** |  **1.2512** |      **-** |   **7.73 KB** |
| SerializeWithMessagePackLZ4   | 10           |  12.872 μs |  0.2145 μs |  0.1902 μs |  12.846 μs |  0.3204 |      - |   2.02 KB |
| SerializeWithNewtonsoftJson   | 10           |  42.438 μs |  0.4327 μs |  0.3836 μs |  42.494 μs | 11.4746 | 1.0986 |  70.73 KB |
| SerializeWithSystemTextJson   | 10           |  17.828 μs |  0.2707 μs |  0.2532 μs |  17.911 μs |  4.0283 |      - |   24.8 KB |
| DeserializeWithMessagePack    | 10           |  16.653 μs |  0.2190 μs |  0.2048 μs |  16.683 μs |  2.6550 | 0.1221 |   16.3 KB |
| DeserializeWithMessagePackLZ4 | 10           |  16.803 μs |  0.2165 μs |  0.2025 μs |  16.857 μs |  2.6550 | 0.1526 |  16.36 KB |
| DeserializeWithNewtonsoftJson | 10           |  63.276 μs |  1.0714 μs |  1.0022 μs |  63.437 μs |  5.0049 | 0.2441 |  30.94 KB |
| DeserializeWithSystemTextJson | 10           |  34.304 μs |  0.4684 μs |  0.3911 μs |  34.370 μs |  3.0518 | 0.1831 |  18.87 KB |
| **SerializeWithMessagePack**      | **20**           |  **17.466 μs** |  **0.2133 μs** |  **0.1995 μs** |  **17.496 μs** |  **2.5024** |      **-** |  **15.43 KB** |
| SerializeWithMessagePackLZ4   | 20           |  23.817 μs |  0.2357 μs |  0.2205 μs |  23.866 μs |  0.5493 |      - |   3.41 KB |
| SerializeWithNewtonsoftJson   | 20           |  82.851 μs |  1.1444 μs |  1.0705 μs |  83.114 μs | 22.7051 | 3.7842 |  139.6 KB |
| SerializeWithSystemTextJson   | 20           |  36.496 μs |  0.6721 μs |  0.6287 μs |  36.609 μs |  7.9346 |      - |  48.77 KB |
| DeserializeWithMessagePack    | 20           |  33.382 μs |  0.4473 μs |  0.4184 μs |  33.408 μs |  5.3101 | 0.4883 |  32.55 KB |
| DeserializeWithMessagePackLZ4 | 20           |  33.472 μs |  0.5260 μs |  0.4663 μs |  33.701 μs |  5.3101 | 0.5493 |  32.61 KB |
| DeserializeWithNewtonsoftJson | 20           | 126.017 μs |  1.4790 μs |  1.3834 μs | 125.722 μs |  9.5215 | 0.9766 |  59.65 KB |
| DeserializeWithSystemTextJson | 20           |  70.774 μs |  1.0650 μs |  0.9962 μs |  70.674 μs |  5.8594 | 0.6104 |  36.33 KB |
| **SerializeWithMessagePack**      | **30**           |  **26.489 μs** |  **0.3686 μs** |  **0.3267 μs** |  **26.511 μs** |  **3.7537** |      **-** |  **23.13 KB** |
| SerializeWithMessagePackLZ4   | 30           |  36.281 μs |  0.5140 μs |  0.4808 μs |  36.288 μs |  0.7935 |      - |   4.88 KB |
| SerializeWithNewtonsoftJson   | 30           | 122.039 μs |  0.8267 μs |  0.7328 μs | 122.082 μs | 31.0059 | 5.1270 |  192.8 KB |
| SerializeWithSystemTextJson   | 30           |  56.447 μs |  0.5092 μs |  0.4514 μs |  56.511 μs | 11.7188 |      - |  72.74 KB |
| DeserializeWithMessagePack    | 30           |  49.980 μs |  0.7101 μs |  0.6295 μs |  49.920 μs |  7.9346 | 1.0376 |   48.8 KB |
| DeserializeWithMessagePackLZ4 | 30           |  52.084 μs |  0.9725 μs |  2.3114 μs |  51.193 μs |  7.9346 | 1.0986 |  48.86 KB |
| DeserializeWithNewtonsoftJson | 30           | 191.749 μs |  2.5023 μs |  1.9536 μs | 191.746 μs | 14.1602 | 1.9531 |  88.09 KB |
| DeserializeWithSystemTextJson | 30           | 134.821 μs | 10.7527 μs | 31.7047 μs | 128.287 μs |  8.6670 | 1.2207 |  53.52 KB |
