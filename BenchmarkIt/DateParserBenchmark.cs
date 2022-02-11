using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace BenchmarkIt
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class DateParserBenchmark
    {
        private const string DateTime = "2022-02-08T15:24:18Z";

        private static readonly DateParser Parser = new();

        [Benchmark(Baseline = true)]
        public void GetYearFromDateTime_Benchmark()
        {
            Parser.GetYearFromDateTime(DateTime);
        }

        [Benchmark]
        public void GetYearFromDateTime_WithSplit_Benchmark()
        {
            Parser.GetYearFromSplit(DateTime);
        }

        [Benchmark]
        public void GetYearFromDateTime_WithSubstring_Benchmark()
        {
            Parser.GetYearFromSubstring(DateTime);
        }

        [Benchmark]
        public void GetYearFromDateTime_WithSpan_Benchmark()
        {
            Parser.GetYearFromSpan(DateTime);
        }
    }
}
