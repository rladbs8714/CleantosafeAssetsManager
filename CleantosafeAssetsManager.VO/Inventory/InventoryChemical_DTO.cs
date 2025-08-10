using System.Text.Json.Serialization;

namespace CleantosafeAssetsManager.DTO
{
    public class InventoryChemical_DTO : InventoryElement_DTO
    {
        public class MinMax
        {
            [JsonPropertyName("Min")]
            public float Min { get; set; }

            [JsonPropertyName("Max")]
            public float Max { get; set; }

            public override string ToString()
            {
                return $"{Min}-{Max}";
            }
        }

        [JsonPropertyName("BrandName")]
        public string BrandName { get; set; }

        [JsonPropertyName("Purpose")]
        public string Purpose { get; set; }

        [JsonPropertyName("pH")]
        public MinMax? pH { get; set; }
    }
}
