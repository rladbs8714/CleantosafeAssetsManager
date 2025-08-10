namespace CleantosafeAssetsManager.DTO
{
    public class InventoryEquipment_DTO : InventoryElement_DTO
    {
        /// <summary>
        /// 제조사 명
        /// </summary>
        public string BrandName { get; set; }
        /// <summary>
        /// 용도
        /// </summary>
        public string Purpose { get; set; }
    }
}
