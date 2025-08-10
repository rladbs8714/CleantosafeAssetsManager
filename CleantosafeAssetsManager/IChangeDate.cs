namespace CleantosafeAssetsManager
{
    public interface IChangeDate
    {
        DateTime Date { get; }
        void AddChangeDateEvent(Action<object?, DateRangeEventArgs> action);
        void RemoveChangeDateEvent(Action<object?, DateRangeEventArgs> action);
    }
}
