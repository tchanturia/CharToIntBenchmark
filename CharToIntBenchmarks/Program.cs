﻿using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace CharToIntBenchmarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<CharToIntBenchmark>();
        }
    }

    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.NetCoreApp31)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net60)]
    public class CharToIntBenchmark
    {
        string stringNumber = "1234";

        [Benchmark]
        public int IntParse() => int.Parse(stringNumber.AsSpan(0, 1));

        [Benchmark]
        public int SubtractAndCast() => stringNumber[0] - '0';

        [Benchmark]
        public (bool, int) TryParse()
        {
            var result = int.TryParse(stringNumber.AsSpan(0, 1), out var digit);
            return (result, digit);
        }

        [Benchmark]
        public (bool, int) TrySubtractAndCast_PositiveNegativeCheck()
        {
            var digit = stringNumber[0] - '0';
            return (digit > -10 && digit < 10, digit);
        }

        [Benchmark]
        public (bool, int) TrySubtractAndCast_Abs()
        {
            var digit = stringNumber[0] - '0';
            return (Math.Abs(digit) < 10, digit);
        }

        [Benchmark]
        public int Bitwise() => stringNumber[0] ^ 48;
    }
}
