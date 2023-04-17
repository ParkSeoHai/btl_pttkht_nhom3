using DAL_BHQA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_BHQA
{
    public class BUS_QuenMK
    {
        DAL_QuenMK dal_QuenMK = new DAL_QuenMK();
        // Lấy lại mk khách hàng
        public string LayLaiPass(string txtEmail)
        {
            return dal_QuenMK.LayLaiPass(txtEmail);
        }
    }
}
