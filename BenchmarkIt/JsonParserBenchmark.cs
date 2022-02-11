using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace BenchmarkIt
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class JsonParserBenchmark
    {
        private static readonly JsonParser Parser = new();

        private readonly SomeDto someDto = new()
        {
            Id = 1024,
            Name = "Adam Stirtan",
            Description = "code, dad, sleep, repeat",
            NullableInt = null,
            Likes = 50,
            Created = DateTime.Now
        };

        [Benchmark]
        public void Serialize_SystemTextJson()
        {
            Parser.SerializeWithSystemTextJson(someDto);
        }

        [Benchmark]
        public void Serialize_NewtonsoftJson()
        {
            Parser.SerializeWithNewtonsoftJson(someDto);
        }
    }
}
