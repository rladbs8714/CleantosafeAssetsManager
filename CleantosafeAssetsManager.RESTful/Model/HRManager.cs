using CleantosafeAssetsManager.DTO;

namespace CleantosafeAssetsManager.RESTful.Model
{

    /*
     *  ===========================================================================
     *  작성자     : @yoon
     *  최초 작성일: 2025.07.05
     *  
     *  < 목적 >
     *  - HR 관리자 클래스.
     *    CleantosafeAssetsManager의 인력 자산 관리를 RESTful에서 관리하고자 만듦.
     *  
     *  < TODO >
     *  -
     *  
     *  < History >
     *  2025.07.05 @yoon
     *  - 최초 작성
     *  ===========================================================================
     */

    public class HRManager : DTOFileManager<HRMHuman_DTO>
    {

        // ====================================================================
        // CONSTANTS
        // ====================================================================

        /// <summary>
        /// HRM을 저장하는 json 파일 경로
        /// </summary>
        private const string HRM_FILE_NAME = "HRM\\human_resources.json";


        // ====================================================================
        // CONSTRUCTORS
        // ====================================================================

        public HRManager() : base(HRM_FILE_NAME)
        {

        }

    }
}
