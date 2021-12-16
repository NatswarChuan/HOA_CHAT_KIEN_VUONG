using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HOA_CHAT_KIEN_VUONG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet("all")]
        public string All()
        {
            var query = LoaiHC.LoaiHang_Select().Select();
            int count = query.Length;
            return count == 0 ? "[]" : JsonConvert.SerializeObject(query[0].Table, Formatting.Indented);
        }
    }
}
