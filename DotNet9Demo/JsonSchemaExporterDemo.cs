using System.Text.Json;
using System.Text.Json.Schema;

namespace DotNet9Demo;
internal static class JsonSchemaExporterDemo
{
    public static void JsonSchemaExporterDotNet9()
    {
        var jsonSchema = JsonSchemaExporter
            .GetJsonSchemaAsNode(
            JsonSerializerOptions.Default,
            typeof(Product));

        Console.WriteLine(jsonSchema);
    }

    public class Product
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
