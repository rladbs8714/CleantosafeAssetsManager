namespace CleantosafeAssetsManager.DTO
{
    public interface IInventoryRequired : IDTORequired
    {
        double Qty { get; set; }

        string Description { get; set; }
    }
}
