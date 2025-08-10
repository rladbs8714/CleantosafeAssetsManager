namespace CleantosafeAssetsManager.DTO
{
    public interface ICRUD<T> where T : IDTORequired
    {
        // GET with name (first from GETs)
        bool TryGet(string name, out T? t);

        // GET with guid
        bool TryGet(Guid guid, out T? t);

        // GET[] with name
        bool TryGets(string name, out IEnumerable<T>? t);

        // ADD T
        void Add(T t);

        // ADD range T[]
        void AddRange(T[] t);

        // UPDATE with guid
        bool TryUpdate(T @new);

        // DELETE with guid
        bool TryDelete(Guid guid);
    }
}
