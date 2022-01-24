namespace BlazorConstraint
{
    public class SimpleData : IMyInterface
    {
        public static readonly IEnumerable<SimpleData> List = new[] { new SimpleData { Name = "1" }, new SimpleData { Name = "2" } };
        public string Name { get; set; } = default!;
    }
}
