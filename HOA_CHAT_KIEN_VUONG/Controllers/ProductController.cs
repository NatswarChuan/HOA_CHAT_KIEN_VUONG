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
    public class ProductController : ControllerBase
    {
        [HttpGet("get/{id}")]
        public string Get(string id)
        {
            var query = HoaChat.SanPham_KTra(id).Select($"MAHANGHOA = '{id}'");
            int count = query.Length;
            return count == 0 ? "[]" : JsonConvert.SerializeObject(query[0].Table, Formatting.Indented);
        }

        [HttpGet("all")]
        public string All()
        {
            var query = HoaChat.SanPham_Select().Select();
            int count = query.Length;
            return count == 0 ? "[]" : JsonConvert.SerializeObject(query[0].Table, Formatting.Indented);
        }

        [HttpGet("category/{MALOAI}")]
        public string Category(string MALOAI)
        {
            var query = HoaChat.SANPHAM_SELECT_LOAI(MALOAI).Select();
            int count = query.Length;
            return count == 0 ? "[]" : JsonConvert.SerializeObject(query[0].Table, Formatting.Indented);
        }

        [HttpGet("search/{SEARCH}")]
        public string Search(string SEARCH)
        {
            var query = HoaChat.SANPHAM_SEARCH(SEARCH).Select();
            int count = query.Length;
            return count == 0 ? "[]" : JsonConvert.SerializeObject(query[0].Table, Formatting.Indented);
        }
    }
}
