using CleantosafeAssetsManager.DTO;
using System.Text.Json;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<HRMHuman_DTO> list = new List<HRMHuman_DTO>();
            list.Add(new HRMHuman_DTO()
            {
                Guid = Guid.NewGuid(),
                Name = "Test",
            });

            string json = JsonSerializer.Serialize(list);
            Console.WriteLine(json);
        }
    }
}
