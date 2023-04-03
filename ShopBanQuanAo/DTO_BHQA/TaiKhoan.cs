using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BHQA
{
    public class TaiKhoan
    {
        private string tenTaiKhoan;
        private string matKhau;

        public TaiKhoan()
        {

        }
        public TaiKhoan(string tenTaiKhoan, string matKhau, string maKhachHang)
        {
            this.tenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;

        }

        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }

    }
}
