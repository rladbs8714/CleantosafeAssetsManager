using Generalibrary;
using System.Reflection;
using System.Text.Json;

namespace CleantosafeAssetsManager.Core.IO
{
    public class DTOFileIO<T>
    {

        // ====================================================================
        // CONSTANTS
        // ====================================================================

        private const string LOG_TYPE = "DTOFileIO";

        /// <summary>
        /// 관리 파일을 저장하는 json 파일 경로
        /// </summary>
        private readonly string FILE_PATH;

        private readonly ILog Log = LogManager.Instance;


        // ====================================================================
        // CONSTRUCTORS
        // ====================================================================

        /// <summary>
        /// DTOFileIO 기본 생성자
        /// </summary>
        /// <param name="path">관리 파일을 저장하는 파일 경로</param>
        /// <exception cref="ArgumentNullException"><paramref name="path"/>이 null 혹은 <seealso cref="string.Empty"/>일 때</exception>
        public DTOFileIO(string path)
        {
            string doc = MethodBase.GetCurrentMethod().Name;

            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException($"{nameof(path)} is null or empty");

            FILE_PATH = path;
        }


        // ====================================================================
        // METHODS
        // ====================================================================

        /// <summary>
        /// <paramref name="content"/>를 사전 정의된 경로에 저장한다.
        /// </summary>
        /// <param name="content">저장할 내용</param>
        /// <exception cref="ArgumentNullException"><paramref name="content"/>이 null 혹은 <seealso cref="string.Empty"/> 일 때</exception>
        public virtual void SaveFile(string content)
        {
            string doc = MethodBase.GetCurrentMethod().Name;

            if (string.IsNullOrEmpty(content))
                throw new ArgumentNullException($"{nameof(content)}가 null 혹은 공백입니다.");

            try
            {
                File.WriteAllText(FILE_PATH, content);
            }
            catch (ArgumentNullException)
            {
                Log.Error(LOG_TYPE, doc, $"{nameof(FILE_PATH)}가 null 입니다.");
            }
            catch (PathTooLongException)
            {
                Log.Error(LOG_TYPE, doc, $"{nameof(FILE_PATH)}가 시스템 정의 최대 길이를 초과합니다. (Length: {FILE_PATH.Length})");
            }
            catch (DirectoryNotFoundException)
            {
                Log.Error(LOG_TYPE, doc, $"{nameof(FILE_PATH)}의 경로가 잘못되었습니다. ({nameof(FILE_PATH)}: {FILE_PATH})");
            }
            catch (IOException)
            {
                Log.Error(LOG_TYPE, doc, $"{nameof(FILE_PATH)} 파일을 여는 동안 I/O 오류가 발생했습니다.");
            }
            catch (NotSupportedException)
            {
                Log.Error(LOG_TYPE, doc, $"{nameof(FILE_PATH)}가 잘못된 형식입니다. ({nameof(FILE_PATH)}: {FILE_PATH})");
            }
        }

        /// <summary>
        /// <see cref="FILE_PATH"/> 파일 로드를 시도한다.
        /// </summary>
        /// <param name="content">파일로드에 성공했다면 읽은 파일의 내용을, 그렇지 않다면 <seealso cref="string.Empty"/></param>
        /// <returns>파일 로드에 성공했다면 true, 그렇지 않다면 false</returns>
        public virtual bool TryLoadFile(out string content)
        {
            string doc = MethodBase.GetCurrentMethod().Name;

            content = string.Empty;
            try
            {
                content = File.ReadAllText(FILE_PATH);
            }
            catch (ArgumentNullException)
            {
                Log.Error(LOG_TYPE, doc, $"{nameof(FILE_PATH)}가 null 입니다.");
                return false;
            }
            catch (PathTooLongException)
            {
                Log.Error(LOG_TYPE, doc, $"{nameof(FILE_PATH)}가 시스템 정의 최대 길이를 초과합니다. (Length: {FILE_PATH.Length})");
                return false;
            }
            catch (DirectoryNotFoundException)
            {
                Log.Error(LOG_TYPE, doc, $"{nameof(FILE_PATH)}의 경로가 잘못되었습니다. ({nameof(FILE_PATH)}: {FILE_PATH})");
                return false;
            }
            catch (FileNotFoundException)
            {
                Log.Error(LOG_TYPE, doc, $"{nameof(FILE_PATH)}의 파일이 존재하지 않습니다. {Path.GetDirectoryName(FILE_PATH)} 경로에 공백파일을 생성합니다.");
                List<T> values = new List<T>();
                string json = JsonSerializer.Serialize(values);
                SaveFile(json);
                return true;
            }
            catch (IOException)
            {
                Log.Error(LOG_TYPE, doc, $"{nameof(FILE_PATH)} 파일을 여는 동안 I/O 오류가 발생했습니다.");
                return false;
            }
            catch (NotSupportedException)
            {
                Log.Error(LOG_TYPE, doc, $"{nameof(FILE_PATH)}가 잘못된 형식입니다. ({nameof(FILE_PATH)}: {FILE_PATH})");
                return false;
            }

            return true;
        }
    }
}
