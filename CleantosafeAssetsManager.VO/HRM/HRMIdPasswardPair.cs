using System.Text.Json.Serialization;

namespace CleantosafeAssetsManager.DTO
{
    public struct HRMIdPasswardPair
    {
        [JsonPropertyName("ID")]
        public string ID { get; set; }

        [JsonPropertyName("PW")]
        public string Passward { get; set; }

        public HRMIdPasswardPair(HRMIdPasswardPair pair)
        {
            ID = pair.ID;
            Passward = pair.Passward;
        }

        public override string ToString()
        {
            return $"{ID},{Passward}";
        }

        public string ToString(bool onlyId = false)
        {
            return onlyId ? ID : $"{ID},{Passward}";
        }
    }
}
