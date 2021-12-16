using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HOA_CHAT_KIEN_VUONG.Model
{
    public class User
    {
        public string MaKH { get; set; }
        public string MatKhau { get; set; }
        public User(string _MaKH, string _MatKhau)
        {
            MaKH = _MaKH;
            MatKhau = _MatKhau;
        }
    }
}
