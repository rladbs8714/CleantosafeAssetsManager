using System.Text.Json.Serialization;

namespace CleantosafeAssetsManager.DTO
{
    public class HRMSamsungSDI_DTO
    {
        [JsonPropertyName("VPass")]
        public HRMIdPasswardPair VPass { get; set; }

        [JsonPropertyName("MEHS")]
        public HRMIdPasswardPair MEHS { get; set; }

        public HRMSamsungSDI_DTO() { }

        public HRMSamsungSDI_DTO(HRMSamsungSDI_DTO sdi)
        {
            VPass = sdi.VPass;
            MEHS = sdi.MEHS;
        }

        public void Update(HRMSamsungSDI_DTO sdi)
        {
            VPass = sdi.VPass;
            MEHS = sdi.MEHS;
        }

        public override string ToString()
        {
            return $"{VPass.ToString()},{MEHS.ToString()}";
        }

        public string ToString(bool onlyId = false)
        {
            return $"{VPass.ToString(onlyId)},{MEHS.ToString(onlyId)}";
        }
    }
}
