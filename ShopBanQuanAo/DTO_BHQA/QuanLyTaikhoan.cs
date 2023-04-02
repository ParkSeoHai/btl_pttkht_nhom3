using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BHQA
{
    public class QuanLyTaikhoan
    {
        private string _MaQL;
        private string _TenTK;

        public string MaQL { get => _MaQL; set => _MaQL = value; }
        public string TenTK { get => _TenTK; set => _TenTK = value; }

        public QuanLyTaikhoan() { }
        public QuanLyTaikhoan(string MaQL, string TenTK) 
        { 
            _MaQL = MaQL;
            _TenTK = TenTK;
        }
    }
}
