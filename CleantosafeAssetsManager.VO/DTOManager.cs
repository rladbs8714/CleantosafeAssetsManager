using Generalibrary;
using System.Reflection;
using System.Text.Json.Serialization;


namespace CleantosafeAssetsManager.DTO
{

    /*
     *  ===========================================================================
     *  작성자     : @yoon
     *  최초 작성일: 2025.07.15
     *  
     *  < 목적 >
     *  - CleantosafeAssetsManager의 DTO 클래스의 매니저 클래스를 구현한다.
     *  
     *  < TODO >
     *  
     *  < History >
     *  2025.07.15 @yoon
     *  - 최초 작성
     *  ===========================================================================
     */

    /// <summary>
    /// DTO 클래스의 List를 관리하는 매니저 클래스
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DTOManager<T> : ICRUD<T>
        where T : IDTORequired, new()
    {

        // ====================================================================
        // CONSTANTS
        // ====================================================================

        private const string LOG_TYPE = nameof(DTOManager<T>);

        private readonly ILog LOG = LogManager.Instance;


        // ====================================================================
        // PROPERTIES
        // ====================================================================

        public List<T> Values { get; set; }


        // ====================================================================
        // CONSTRUCTORS
        // ====================================================================

        public DTOManager()
        {

        }

        public DTOManager(List<T> values)
        {
            Values = values;
        }


        // ====================================================================
        // METHODS - CRUD
        // ====================================================================

        public void Add(T t)
        {
            Values.Add(t);
        }

        public void AddRange(T[] t)
        {
            Values.AddRange(t);
        }

        public bool TryGetAll(out T[]? result)
        {
            if (Values.Count != 0)
            {
                result = Values.ToArray();
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        public bool TryGet(string name, out T? result)
        {
            if (Values.Count < 1)
            {
                result = default(T);
                return false;
            }

            result = Values.Find(x => x.Name.Equals(name));
            if (result == null)
                return false;

            return true;
        }

        public bool TryGet(Guid guid, out T? result)
        {
            if (Values.Count < 1)
            {
                result = default(T);
                return false;
            }

            result = Values.Find(x => x.Guid.Equals(guid));
            if (result == null)
                return false;

            return true;
        }

        public bool TryGets(string name, out IEnumerable<T>? result)
        {
            if (Values.Count < 1)
            {
                result = null;
                return false;
            }

            result = Values.FindAll(x => x.Name.Equals(name));
            if (result == null)
                return false;

            return true;
        }

        public bool TryUpdate(T newDto)
        {
            T? origin = Values.Find(x => x.Guid.Equals(newDto.Guid));
            if (origin == null)
                return false;

            // copy
            PropertyInfo[] oProps = origin.GetType().GetProperties();
            foreach (PropertyInfo oPi in oProps)
            {
                JsonPropertyNameAttribute? attr = oPi.GetCustomAttribute<JsonPropertyNameAttribute>();
                if (attr == null)
                    continue;

                string attrContent = attr.Name;

                PropertyInfo[] nProps = newDto.GetType().GetProperties();
                foreach (PropertyInfo nPi in nProps)
                {
                    var t = nPi.GetCustomAttribute<JsonPropertyNameAttribute>();
                    if (t == null || !attrContent.Equals(t.Name))
                        continue;

                    oPi.SetValue(origin, nPi.GetValue(newDto));
                    continue;
                }
            }
            return true;
        }

        public bool TryDelete(Guid guid)
        {
            if (!TryGet(guid, out T? r) || r == null)
                return false;

            if (!Values.Remove(r))
            {
                return false;
            }
            return true;
        }
    }
}
