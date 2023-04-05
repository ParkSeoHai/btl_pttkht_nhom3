using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BHQA
{
    public class SP_BanChayReport
    {
        private string _MaSP;
        private string _TenSP;
        private double _DonGia;
        private string _DonViTinh;
        private int _SoLuong;

        public string MaSP { get => _MaSP; set => _MaSP = value; }
        public string TenSP { get => _TenSP; set => _TenSP = value; }
        public double DonGia { get => _DonGia; set => _DonGia = value; }
        public string DonViTinh { get => _DonViTinh; set => _DonViTinh = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }
    }
}
