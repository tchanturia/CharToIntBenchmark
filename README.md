# CharToIntBenchmark

https://github.com/tchanturia/CharToIntBenchmark/blob/d5982ef0f4ba15fc15447747ab900386b6e5a484/CharToIntBenchmarks/Program.cs#L15-L40

```
BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1766 (21H2)
Intel Core i7-10750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.106
  [Host]        : .NET Core 3.1.26 (CoreCLR 4.700.22.26002, CoreFX 4.700.22.26801), X64 RyuJIT
  .NET 6.0      : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.26 (CoreCLR 4.700.22.26002, CoreFX 4.700.22.26801), X64 RyuJIT

|                                   Method |           Job |       Runtime |       Mean |     Error |    StdDev |     Median |
|----------------------------------------- |-------------- |-------------- |-----------:|----------:|----------:|-----------:|
|                                 IntParse |      .NET 6.0 |      .NET 6.0 | 10.6099 ns | 0.2337 ns | 0.2598 ns | 10.5779 ns |
|                          SubtractAndCast |      .NET 6.0 |      .NET 6.0 |  0.0062 ns | 0.0102 ns | 0.0096 ns |  0.0006 ns |
|                                 TryParse |      .NET 6.0 |      .NET 6.0 | 15.8664 ns | 0.3433 ns | 0.3211 ns | 15.6611 ns |
| TrySubtractAndCast_PositiveNegativeCheck |      .NET 6.0 |      .NET 6.0 |  6.2096 ns | 0.1454 ns | 0.1360 ns |  6.1483 ns |
|                   TrySubtractAndCast_Abs |      .NET 6.0 |      .NET 6.0 |  5.9472 ns | 0.1275 ns | 0.1193 ns |  5.9132 ns |
|                                 IntParse | .NET Core 3.1 | .NET Core 3.1 | 14.4707 ns | 0.2158 ns | 0.1802 ns | 14.3912 ns |
|                          SubtractAndCast | .NET Core 3.1 | .NET Core 3.1 |  0.0298 ns | 0.0258 ns | 0.0242 ns |  0.0179 ns |
|                                 TryParse | .NET Core 3.1 | .NET Core 3.1 | 16.7906 ns | 0.0852 ns | 0.0797 ns | 16.7524 ns |
| TrySubtractAndCast_PositiveNegativeCheck | .NET Core 3.1 | .NET Core 3.1 |  6.0824 ns | 0.0265 ns | 0.0235 ns |  6.0704 ns |
|                   TrySubtractAndCast_Abs | .NET Core 3.1 | .NET Core 3.1 |  6.1671 ns | 0.1105 ns | 0.1034 ns |  6.1687 ns |
```
