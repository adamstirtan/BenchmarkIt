namespace BenchmarkIt
{
    public class SomeDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public int Likes { get; set; }

        public int? NullableInt { get; set; }

        public DateTime Created { get; set; }

    }
}
