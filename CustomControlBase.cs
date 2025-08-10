using CleantosafeAssetsManager.Core.IO;
using CleantosafeAssetsManager.DTO;
using Generalibrary;
using RestSharp;
using System.Reflection;
using System.Text.Json;

namespace CleantosafeAssetsManager
{
    /*
     *  ===========================================================================
     *  작성자     : @yoon
     *  최초 작성일: 2025.07.22
     *  
     *  < 목적 >
     *  - CleantosafeAssetsManager의 UserControl Base를 정의한다.
     *  
     *  < TODO >
     *  -
     *  
     *  < History >
     *  2025.07.22 @yoon
     *  - 최초 작성
     *  ===========================================================================
     */

    public abstract class CustomControlBase<T> : UserControl
        where T : IDTORequired, new()
    {
        // ====================================================================
        // FIELDS
        // ====================================================================

        private readonly string LOG_TYPE;
        private readonly ILog   LOG      = LogManager.Instance;
        private readonly string BASE_URL = "https://localhost:7295/api";

        private string _fileName;


        // ====================================================================
        // PROPERTIES
        // ====================================================================

        protected DTOManager<T> Value { get; private set; }
        protected DTOFileIO<T> FileIO { get; private set; }
        protected RestClient   Client { get; private set; }


        // ====================================================================
        // CONSTRUCTORS
        // ====================================================================

        protected CustomControlBase(string fileName, string detailUrl)
        {
            LOG_TYPE = this.GetType().Name;

            BASE_URL = Path.Combine(BASE_URL, detailUrl);

            _fileName = fileName;
            FileIO = new DTOFileIO<T>(fileName);
            Client = new RestClient(BASE_URL);

            InitializeListByJson("get/all");
        }


        // ====================================================================
        // ABSTRACTS
        // ====================================================================

        protected abstract void UpdateList();


        // ====================================================================
        // METHODS
        // ====================================================================

        private void InitializeListByJson(string detailUrl)
        {
            string doc = MethodBase.GetCurrentMethod().Name;
            string json = string.Empty;

#if RESTful
            RestRequest request = new RestRequest(detailUrl, Method.Get);
            request.AddHeader("Content-Type", "application/json; charset=UTF-8");
            
            RestResponse response = Client.ExecuteGet(request);
            json = string.IsNullOrEmpty(response.Content) ? string.Empty : response.Content;
#else
            FileIO.TryLoadFile(out json);
#endif
            List<T>? temp = null;
            try
            {
                temp = JsonSerializer.Deserialize<List<T>>(json);
            }
            catch
            {
                LOG.Error(LOG_TYPE, doc, $"\"{_fileName}\"의 json을 읽어들이는데 실패했습니다.");
            }

            if (temp == null) temp = new List<T>();
            Value = new DTOManager<T>(temp);
        }
    }
}
