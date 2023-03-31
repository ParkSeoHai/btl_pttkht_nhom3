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
        private string _IDTK;

        public string MaQL { get => _MaQL; set => _MaQL = value; }
        public string IDTK { get => _IDTK; set => _IDTK = value; }

        public QuanLyTaikhoan() { }
        public QuanLyTaikhoan(string MaQL, string IDTK) 
        { 
            _MaQL = MaQL;
            _IDTK = IDTK;
        }
    }
}
