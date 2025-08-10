using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Text;
using CleantosafeAssetsManager.RESTful.Model;
using CleantosafeAssetsManager.DTO;


namespace CleantosafeAssetsManager.RESTful.Controllers
{
    /*
     *  ===========================================================================
     *  작성자     : @yoon
     *  최초 작성일: 2025.07.17
     *  
     *  < 목적 >
     *  - CleantosafeAssetsManager의 Inventory 부문 RESTful API를 구현한다.
     *  
     *  < TODO >
     *  - 
     *  
     *  < History >
     *  2025.07.17 @yoon
     *  - 최초 작성
     *  ===========================================================================
     */

    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private InventoryChemicalManager Chemical { get; set; }

        private InventoryEquipmentManager Equipment { get; set; }

        public InventoryController()
        {
            Chemical = new InventoryChemicalManager();
            Equipment = new InventoryEquipmentManager();
        }

        // ====================================================================
        // METHODS - GET
        // ====================================================================

        /// <summary>
        /// 해당 클래스의 모든 기능을 문자열로 반환한다.
        /// Get: api/<seealso cref="InventoryController"/>
        /// </summary>
        /// <returns>클래스의 모든 기능</returns>
        [HttpGet]
        public string GetAllFunction()
        {
            MethodInfo[] mis     = typeof(InventoryController).GetMethods();
            List<string> gets    = [];
            List<string> posts   = [];
            List<string> puts    = [];
            List<string> deletes = [];

            foreach (var mi in mis)
            {
                var get    = mi.CustomAttributes.FirstOrDefault(x => x.AttributeType == typeof(HttpGetAttribute));
                var post   = mi.CustomAttributes.FirstOrDefault(x => x.AttributeType == typeof(HttpPostAttribute));
                var put    = mi.CustomAttributes.FirstOrDefault(x => x.AttributeType == typeof(HttpPutAttribute));
                var delete = mi.CustomAttributes.FirstOrDefault(x => x.AttributeType == typeof(HttpDeleteAttribute));

                if      (get    != null) gets   .Add(mi.Name);
                else if (post   != null) posts  .Add(mi.Name);
                else if (put    != null) puts   .Add(mi.Name);
                else if (delete != null) deletes.Add(mi.Name);
                else continue;
            }

            StringBuilder sb = new();
            sb.AppendLine("[GET]   : " + string.Join("\n[GET]   : ", gets));
            sb.AppendLine("[POST]  : " + string.Join("\n[POST]  : ", posts));
            sb.AppendLine("[PUT]   : " + string.Join("\n[PUT]   : ", puts));
            sb.AppendLine("[DELETE]: " + string.Join("\n[DELETE]: ", deletes));

            return sb.ToString();
        }

        #region Chemical

        // ====================================================================
        // METHODS - GET
        // ====================================================================

        // GET: api/<ValuesController>
        /// <summary>
        /// 모든 약품의 정보를 반환한다.
        /// Get: api/<seealso cref="InventoryController"/>/get/all
        /// </summary>
        /// <returns>모든 약품의 정보</returns>
        [HttpGet("chemical/get/all")]
        public InventoryChemical_DTO[] GetAllChemical()
        {
            if (!Chemical.TryGetAll(out InventoryChemical_DTO[]? r) || r == null)
                return new InventoryChemical_DTO[0];

            return r;
        }

        // GET: api/<ValuesController>/{name}
        /// <summary>
        /// <paramref name="name"/>에 해당하는 약품들을 반환한다.
        /// </summary>
        /// <param name="name">찾을 약품의 이름</param>
        /// <returns><paramref name="name"/>의 이름을 가진 약품</returns>
        [HttpGet("chemical/get/{name}")]
        public InventoryChemical_DTO[] GetChemical(string name)
        {
            if (!Chemical.TryGets(name, out var r) || r == null)
                return new InventoryChemical_DTO[0];
            return r.ToArray();
        }


        // ====================================================================
        // METHODS - POST
        // ====================================================================

        // POST api/<ValuesController>/post
        [HttpPost("chemical/post")]
        public void PostChemical([FromBody] InventoryChemical_DTO value)
        {
            Chemical.Add(value);
            Chemical.SaveFile();
        }


        // ====================================================================
        // METHODS - PUT
        // ====================================================================

        // PUT api/<ValuesController>/put
        [HttpPut("chemical/put")]
        public void PutChemical([FromBody] InventoryChemical_DTO value)
        {
            Chemical.TryUpdate(value);
            Chemical.SaveFile();
        }


        // ====================================================================
        // METHODS - DELETE
        // ====================================================================

        // DELETE api/<ValuesController>/delete/guid
        [HttpDelete("chemical/delete")]
        public void DeleteChemical([FromBody] Guid guid)
        {
            Chemical.TryDelete(guid);
            Chemical.SaveFile();
        }

        #endregion

        #region Equipment

        // ====================================================================
        // METHODS - GET
        // ====================================================================

        // GET: api/<ValuesController>
        /// <summary>
        /// 모든 약품의 정보를 반환한다.
        /// Get: api/<seealso cref="InventoryController"/>/get/all
        /// </summary>
        /// <returns>모든 약품의 정보</returns>
        [HttpGet("equipment/get/all")]
        public InventoryEquipment_DTO[] GetAllEquipment()
        {
            if (!Equipment.TryGetAll(out InventoryEquipment_DTO[]? r) || r == null)
                return new InventoryEquipment_DTO[0];

            return r;
        }

        // GET: api/<ValuesController>/{name}
        /// <summary>
        /// <paramref name="name"/>에 해당하는 약품들을 반환한다.
        /// </summary>
        /// <param name="name">찾을 약품의 이름</param>
        /// <returns><paramref name="name"/>의 이름을 가진 약품</returns>
        [HttpGet("equipment/get/{name}")]
        public InventoryEquipment_DTO[] GetEquipment(string name)
        {
            if (!Equipment.TryGets(name, out var r) || r == null)
                return new InventoryEquipment_DTO[0];
            return r.ToArray();
        }


        // ====================================================================
        // METHODS - POST
        // ====================================================================

        // POST api/<ValuesController>/post
        [HttpPost("equipment/post")]
        public void PostEquipment([FromBody] InventoryEquipment_DTO value)
        {
            Equipment.Add(value);
            Equipment.SaveFile();
        }


        // ====================================================================
        // METHODS - PUT
        // ====================================================================

        // PUT api/<ValuesController>/put
        [HttpPut("equipment/put")]
        public void PutEquipment([FromBody] InventoryEquipment_DTO value)
        {
            Equipment.TryUpdate(value);
            Equipment.SaveFile();
        }


        // ====================================================================
        // METHODS - DELETE
        // ====================================================================

        // DELETE api/<ValuesController>/delete/guid
        [HttpDelete("equipment/delete")]
        public void DeleteEquipment([FromBody] Guid guid)
        {
            Equipment.TryDelete(guid);
            Equipment.SaveFile();
        }

        #endregion
    }
}
