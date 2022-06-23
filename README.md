# CharToIntBenchmark

```
|          Method |           Job |       Runtime |       Mean |     Error |    StdDev |     Median |
|---------------- |-------------- |-------------- |-----------:|----------:|----------:|-----------:|
|        IntParse |      .NET 6.0 |      .NET 6.0 |  9.6911 ns | 0.2233 ns | 0.3274 ns |  9.6019 ns |
| SubtractAndCast |      .NET 6.0 |      .NET 6.0 |  0.0036 ns | 0.0073 ns | 0.0057 ns |  0.0000 ns |
|        IntParse | .NET Core 3.1 | .NET Core 3.1 | 15.1600 ns | 0.3045 ns | 0.2543 ns | 15.1015 ns |
| SubtractAndCast | .NET Core 3.1 | .NET Core 3.1 |  0.0366 ns | 0.0063 ns | 0.0056 ns |  0.0366 ns |
```
