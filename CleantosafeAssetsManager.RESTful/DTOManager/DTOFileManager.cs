using CleantosafeAssetsManager.Core.IO;
using CleantosafeAssetsManager.DTO;
using CleantosafeAssetsManager.RESTful.Model;
using Generalibrary;
using System.Reflection;
using System.Text.Json;

namespace CleantosafeAssetsManager.RESTful
{

    /*
     *  ===========================================================================
     *  작성자     : @yoon
     *  최초 작성일: 2025.07.17
     *  
     *  < 목적 >
     *  - DTO -> File / File -> DTO를 위한 클래스
     *  
     *  < TODO >
     *  -
     *  
     *  < History >
     *  2025.07.17 @yoon
     *  - 최초 작성
     *  ===========================================================================
     */

    public class DTOFileManager<T> : DTOManager<T>
        where T : IDTORequired, new()
    {
        // ====================================================================
        // FIELDS
        // ====================================================================

        private readonly string LOG_TYPE;

        private readonly ILog LOG = LogManager.Instance;


        // ====================================================================
        // PROPERTIES
        // ====================================================================

        protected DTOFileIO<HRMHuman_DTO> DTOFileIO { get; private set; }


        // ====================================================================
        // CONSTRUCTORS
        // ====================================================================

        public DTOFileManager(string filePath) : base()
        {
            LOG_TYPE = this.GetType().Name;
            string doc = MethodBase.GetCurrentMethod().Name;

            DTOFileIO = new DTOFileIO<HRMHuman_DTO>(filePath);

            if (!DTOFileIO.TryLoadFile(out string content))
                LOG.Error(LOG_TYPE, doc, $"\"{nameof(filePath)}\" 파일을 정상적으로 불러오지 못했습니다. (file name: {filePath})");

            if (string.IsNullOrEmpty(content))
                LOG.Error(LOG_TYPE, doc, $"\"{nameof(content)}\"가 null 혹은 공백입니다.");

            List<T>? temp = null;
            try
            {
                temp = JsonSerializer.Deserialize<List<T>>(content);
            }
            catch
            {
                LOG.Error(LOG_TYPE, doc, $"\"{content}\"는 \"{typeof(List<HRMHuman_DTO>)}\" 타입으로 파싱될 수 없습니다. ({nameof(content)}: {content})");
            }

            temp ??= new List<T>();
            Values = temp;
        }


        // ====================================================================
        // METHODS
        // ====================================================================

        public void SaveFile()
        {
            if (Values.Count < 1)
                return;

            string json = JsonSerializer.Serialize(Values);
            if (string.IsNullOrEmpty(json))
                return;

            DTOFileIO.SaveFile(json);
        }
    }
}
