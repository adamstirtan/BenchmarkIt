namespace BenchmarkIt
{
    public class JsonParser
    {
        public string SerializeWithSystemTextJson(SomeDto dto)
        {
            return System.Text.Json.JsonSerializer.Serialize(dto);
        }

        public string SerializeWithNewtonsoftJson(SomeDto dto)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(dto);
        }
    }
}
