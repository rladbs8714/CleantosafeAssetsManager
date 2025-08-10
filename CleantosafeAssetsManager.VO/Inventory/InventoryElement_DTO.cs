using System.Text.Json.Serialization;

namespace CleantosafeAssetsManager.DTO
{
    public class InventoryElement_DTO : IInventoryRequired
    {
        [JsonPropertyName("Guid")]
        public Guid Guid { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Qty")]
        public double Qty { get; set; }

        [JsonPropertyName("Description")]
        public string Description { get; set; }
    }
}
