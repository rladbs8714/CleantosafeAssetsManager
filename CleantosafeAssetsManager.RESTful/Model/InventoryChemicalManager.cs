using CleantosafeAssetsManager.DTO;

namespace CleantosafeAssetsManager.RESTful.Model
{

    /*
     *  ===========================================================================
     *  작성자     : @yoon
     *  최초 작성일: 2025.07.17
     *  
     *  < 목적 >
     *  - Inventory 관리자 클래스.
     *    CleantosafeAssetsManager의 Inventory-Chemical 관리를 RESTful에서 관리하고자 만듦.
     *  
     *  < TODO >
     *  -
     *  
     *  < History >
     *  2025.07.17 @yoon
     *  - 최초 작성
     *  ===========================================================================
     */

    public class InventoryChemicalManager : DTOFileManager<InventoryChemical_DTO>
    {


        // ====================================================================
        // CONSTANTS
        // ====================================================================

        /// <summary>
        /// Inventory-Chemical을 저장하는 json 파일 경로
        /// </summary>
        private const string INVENTORY_CHEMICAL_FILE_NAME = "inventory\\chemical.json";
        

        // ====================================================================
        // CONSTRUCTORS
        // ====================================================================

        public InventoryChemicalManager() : base(INVENTORY_CHEMICAL_FILE_NAME)
        {

        }
    }
}
