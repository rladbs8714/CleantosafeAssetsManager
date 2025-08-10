using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Text;
using CleantosafeAssetsManager.RESTful.Model;
using CleantosafeAssetsManager.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleantosafeAssetsManager.RESTful.Controllers
{
    /*
     *  ===========================================================================
     *  작성자     : @yoon
     *  최초 작성일: 2025.07.06
     *  
     *  < 목적 >
     *  - CleantosafeAssetsManager의 HR 부문 RESTful API를 구현한다.
     *  
     *  < TODO >
     *  - HRM 데이터를 현재 파일에서 건드리는게 아니라
     *    별도의 클래스나 컨트롤러에서 관리하는 구조로 변경해야 함. 2025.07.10 @yoon
     *  
     *  < History >
     *  2025.07.06 @yoon
     *  - 최초 작성
     *  ===========================================================================
     */

    [Route("api/[controller]")]
    [ApiController]
    public class HRMController : ControllerBase
    {
        private HRManager HRM { get; set; }

        public HRMController()
        {
            HRM = new HRManager();
        }

        // ====================================================================
        // METHODS - GET
        // ====================================================================

        /// <summary>
        /// 해당 클래스의 모든 기능을 문자열로 반환한다.
        /// Get: api/<seealso cref="HRMController"/>
        /// </summary>
        /// <returns>클래스의 모든 기능</returns>
        [HttpGet]
        public string GetAllFunction()
        {
            MethodInfo[] mis     = typeof(HRMController).GetMethods();
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

        // GET: api/<ValuesController>
        /// <summary>
        /// 모든 인원의 정보를 반환한다.
        /// Get: api/<seealso cref="HRMController"/>/get/all
        /// </summary>
        /// <returns>모든 인원의 정보</returns>
        [HttpGet("get/all")]
        public HRMHuman_DTO[] GetAll()
        {
            if (!HRM.TryGetAll(out HRMHuman_DTO[]? r) || r == null)
                return new HRMHuman_DTO[0];

            return r;
        }

        // GET: api/<ValuesController>/{name}
        /// <summary>
        /// <paramref name="name"/>의 인원들을 반환한다.
        /// </summary>
        /// <param name="name">찾을 인원의 이름</param>
        /// <returns><paramref name="name"/>의 이름을 가진 인원</returns>
        [HttpGet("get/{name}")]
        public HRMHuman_DTO[] GetHuman(string name)
        {
            //return HRManager.Humans.Humans.Where(x => x.Name.Equals(name)).ToArray();
            if (!HRM.TryGets(name, out var r) || r == null)
                return new HRMHuman_DTO[0];
            return r.ToArray();
        }


        // ====================================================================
        // METHODS - POST
        // ====================================================================

        // POST api/<ValuesController>/post
        [HttpPost("post")]
        public void Post([FromBody] HRMHuman_DTO value)
        {
            HRM.Add(value);
            HRM.SaveFile();
        }


        // ====================================================================
        // METHODS - PUT
        // ====================================================================

        // PUT api/<ValuesController>/put
        [HttpPut("put")]
        public void Put([FromBody] HRMHuman_DTO value)
        {
            HRM.TryUpdate(value);
            HRM.SaveFile();
        }


        // ====================================================================
        // METHODS - DELETE
        // ====================================================================

        // DELETE api/<ValuesController>/delete/guid
        [HttpDelete("delete")]
        public void Delete([FromBody] Guid guid)
        {
            HRM.TryDelete(guid);
            HRM.SaveFile();
        }
    }
}
