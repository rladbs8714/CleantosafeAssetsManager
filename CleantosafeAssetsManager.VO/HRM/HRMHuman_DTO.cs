using System.Text;
using System.Text.Json.Serialization;

namespace CleantosafeAssetsManager.DTO
{
    public class HRMHuman_DTO : IDTORequired
    {
        public enum EFormat
        {
            Name = 1,
            PhoneNumber = 2,
            BirthDate = 4,
            Gender = 8,
            Address = 16,
            SamsungSDI = 32,
            SKHynix = 64,
            All = 127,
        }

        [JsonPropertyName("Guid")]
        public Guid Guid { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonPropertyName("BirthDate")]
        public DateTime BirthDate { get; set; }

        [JsonPropertyName("Gender")]
        public string Gender { get; set; }

        [JsonPropertyName("Address")]
        public string Address { get; set; }

        [JsonPropertyName("SamsungSDI")]
        public HRMSamsungSDI_DTO? SamsungSDI { get; set; }

        [JsonPropertyName("SKHynix")]
        public HRMSKHynix_DTO? SKHynix { get; set; }

        public HRMHuman_DTO() { }

        public void Update(HRMHuman_DTO update)
        {
            if (update == null)
                return;

            Name = update.Name;
            PhoneNumber = update.PhoneNumber;
            BirthDate = update.BirthDate;
            Gender = update.Gender;
            Address = update.Address;
            if (update.SamsungSDI != null)
                SamsungSDI = new HRMSamsungSDI_DTO(update.SamsungSDI);
            if (update.SKHynix != null)
                SKHynix = new HRMSKHynix_DTO(update.SKHynix);
        }

        public override string ToString()
        {
            return $"{Name},{PhoneNumber},{BirthDate.ToString("yyyyMMdd")},{Gender},{Address},{SamsungSDI?.ToString()},{SKHynix?.ToString()}";
        }

        public string ToString(EFormat format)
        {
            StringBuilder sb = new StringBuilder();
            
            if ((format & EFormat.Name) == EFormat.Name)
                sb.Append($"{Name},");
            if ((format & EFormat.PhoneNumber) == EFormat.PhoneNumber)
                sb.Append($"{PhoneNumber},");
            if ((format & EFormat.BirthDate) == EFormat.BirthDate)
                sb.Append($"{BirthDate.ToString("yyyyMMdd")},");
            if ((format & EFormat.Gender) == EFormat.Gender)
                sb.Append($"{Gender},");
            if ((format & EFormat.Address) == EFormat.Address)
                sb.Append($"{Address},");
            if ((format & EFormat.SamsungSDI) == EFormat.SamsungSDI)
                sb.Append($"{SamsungSDI?.ToString(false)},");
            if ((format & EFormat.SKHynix) == EFormat.SKHynix)
                sb.Append($"{SKHynix?.ToString(false)},");
            sb.Remove(sb.Length - 1, 1);

            return sb.ToString();
        }
    }
}
