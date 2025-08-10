namespace CleantosafeAssetsManager.DTO
{
    /// <summary>
    /// DTO 클래스의 필수 요소
    /// </summary>
    public interface IDTORequired
    {
        Guid Guid { get; set; }

        string Name { get; set; }
    }
}
