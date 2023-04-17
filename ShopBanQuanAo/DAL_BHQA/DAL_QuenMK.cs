using DTO_BHQA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BHQA
{
    public class DAL_QuenMK
    {
        KhachHang KH = new KhachHang();
        public string LayLaiPass(string txtEmail)
        {
            return KH.LayLaiPass(txtEmail);
        }
    }
}
