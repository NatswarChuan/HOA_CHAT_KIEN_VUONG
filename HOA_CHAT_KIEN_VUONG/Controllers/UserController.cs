using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net.Http;

namespace HOA_CHAT_KIEN_VUONG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {

        [HttpPost("login")]
        public string Login([FromForm, FromBody] string MATK, [FromForm, FromBody] string MATKHAU)
        {
            var query = TaiKhoan.DangNhap(MATK, MATKHAU).Select($"MATAIKHOAN = '{MATK}'");
            int count = query.Length;
            return count == 0 ? "[]" : JsonConvert.SerializeObject(query[0].Table, Newtonsoft.Json.Formatting.Indented);
        }

        [HttpPut("register")]
        public bool Register([FromForm, FromBody] string MATK,
            [FromForm, FromBody] string MATKHAU,
            [FromForm, FromBody] string HOTEN,
            [FromForm, FromBody] string GIOITINH,
            [FromForm, FromBody] string DIACHI,
            [FromForm, FromBody] string EMAIL)
        {
            return -1 != TaiKhoan.DangKy(MATK, MATKHAU, "KH", HOTEN, GIOITINH, DIACHI, EMAIL);
        }

        [HttpGet("get/{MATK}")]
        public string Get(string MATK)
        {
            var query = TaiKhoan.LayThongTin(MATK).Select($"MATAIKHOAN = '{MATK}'");
            int count = query.Length;
            return count == 0 ? "[]" : JsonConvert.SerializeObject(query[0].Table, Newtonsoft.Json.Formatting.Indented);
        }

        [HttpPatch("update")]
        public string Update([FromForm, FromBody] string MATK, [FromForm, FromBody] string HINHANH, [FromForm, FromBody] string HOTEN, [FromForm, FromBody] string SODIENTHOAI)
        {
            var query = TaiKhoan.SuaThongTin(MATK, HINHANH, HOTEN, SODIENTHOAI).Select($"MATAIKHOAN = '{MATK}'");
            int count = query.Length;
            return count == 0 ? "[]" : JsonConvert.SerializeObject(query[0].Table, Newtonsoft.Json.Formatting.Indented);
        }

        [HttpPatch("change")]
        public bool Change([FromForm, FromBody] string MATK, [FromForm, FromBody] string MATKHAU)
        {
            return 1 == TaiKhoan.DoiMatKhau(MATK, MATKHAU);
        }

        [HttpGet("check/{MATK}")]
        public bool Check( string MATK)
        {
            var query = TaiKhoan.KiemTraTaiKhoan(MATK).Select($"MATAIKHOAN = '{MATK}'");
            System.Console.WriteLine(query.Length);
            int count = query.Length;
            return count == 1;
        }
    }
}
