using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTO_BHQA
{
    interface IPerson
    {
        string ten { get; set; }
        string ngaySinh { get; set; }
        string diaChi { get; set; }
        string sdt { get; set; }
        string gioiTinh { get; set; }
    }

    public class Person : IPerson
    {
        public string ten { get; set; }
        public string ngaySinh {get; set;}
        public string diaChi {get; set;}
        public string sdt {get; set;}
        public string gioiTinh {get; set;}

        public Person() { }
        public Person(string ten, string ngaySinh, string diaChi, string sdt, string gioiTinh)
        {
            this.ten = ten;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.sdt = sdt;
            this.gioiTinh = gioiTinh;
        }
    }
}