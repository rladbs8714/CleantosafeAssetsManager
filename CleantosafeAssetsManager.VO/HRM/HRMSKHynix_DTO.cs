using System.Text.Json.Serialization;

namespace CleantosafeAssetsManager.DTO
{
    public class HRMSKHynix_DTO
    {
        [JsonPropertyName("Welcome")]
        public HRMIdPasswardPair Welcome { get; set; }

        [JsonPropertyName("SafetyTrainingExpiryDate")]
        public DateTime SafetyTrainingExpiryDate { get; set; }

        public HRMSKHynix_DTO() { }

        public HRMSKHynix_DTO(HRMSKHynix_DTO hynix)
        {
            Welcome = hynix.Welcome;
            SafetyTrainingExpiryDate = hynix.SafetyTrainingExpiryDate;
        }

        public void Update(HRMSKHynix_DTO hynix)
        {
            Welcome = hynix.Welcome;
            SafetyTrainingExpiryDate = hynix.SafetyTrainingExpiryDate;
        }

        public override string ToString()
        {
            return $"{Welcome.ToString()},{SafetyTrainingExpiryDate.ToString("yyyy-MM-dd")}";
        }

        public string ToString(bool onlyId)
        {
            return $"{Welcome.ToString(onlyId)},{SafetyTrainingExpiryDate.ToString("yyyy-MM-dd")}";
        }
    }
}
