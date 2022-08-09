# CharToIntBenchmark

Code's here: https://github.com/tchanturia/CharToIntBenchmark/blob/main/CharToIntBenchmarks/Program.cs

```
BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1766 (21H2)
Intel Core i7-10750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.106
  [Host]        : .NET Core 3.1.26 (CoreCLR 4.700.22.26002, CoreFX 4.700.22.26801), X64 RyuJIT
  .NET 6.0      : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.26 (CoreCLR 4.700.22.26002, CoreFX 4.700.22.26801), X64 RyuJIT


|                                   Method |           Job |       Runtime |       Mean |     Error |    StdDev |     Median |
|----------------------------------------- |-------------- |-------------- |-----------:|----------:|----------:|-----------:|
|                                 IntParse |      .NET 6.0 |      .NET 6.0 |  7.6472 ns | 0.0539 ns | 0.0478 ns |  7.6274 ns |
|                          SubtractAndCast |      .NET 6.0 |      .NET 6.0 |  0.0033 ns | 0.0044 ns | 0.0041 ns |  0.0019 ns |
|                                 TryParse |      .NET 6.0 |      .NET 6.0 | 12.1486 ns | 0.0950 ns | 0.0889 ns | 12.1595 ns |
|                       TrySubtractAndCast |      .NET 6.0 |      .NET 6.0 |   4.699 ns | 0.0982 ns | 0.0820 ns |
|                                  Bitwise |      .NET 6.0 |      .NET 6.0 |  0.0139 ns | 0.0218 ns | 0.0204 ns |  0.0043 ns |
|                                 IntParse | .NET Core 3.1 | .NET Core 3.1 | 12.0210 ns | 0.1235 ns | 0.1031 ns | 12.0362 ns |
|                          SubtractAndCast | .NET Core 3.1 | .NET Core 3.1 |  0.0451 ns | 0.0234 ns | 0.0230 ns |  0.0374 ns |
|                                 TryParse | .NET Core 3.1 | .NET Core 3.1 | 13.0476 ns | 0.1995 ns | 0.1558 ns | 13.0223 ns |
|                       TrySubtractAndCast | .NET Core 3.1 | .NET Core 3.1 |   4.578 ns | 0.0688 ns | 0.0610 ns |
|                                  Bitwise | .NET Core 3.1 | .NET Core 3.1 |  0.0163 ns | 0.0052 ns | 0.0046 ns |  0.0158 ns |
```