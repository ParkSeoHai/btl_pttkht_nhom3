using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BHQA
{
    public class HoaDonReport
    {
        private string _MaKH;
        private string _TenKH;
        private string _MaSP;
        private string _TenSP;
        private string _NgayMua;
        private int _SoLuong;

        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string TenKH { get => _TenKH; set => _TenKH = value; }
        public string MaSP { get => _MaSP; set => _MaSP = value; }
        public string TenSP { get => _TenSP; set => _TenSP = value; }
        public string NgayMua { get => _NgayMua; set => _NgayMua = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }
    }
}
