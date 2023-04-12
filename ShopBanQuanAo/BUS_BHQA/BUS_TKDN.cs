using DAL_BHQA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_BHQA
{
    public class BUS_TKDN
    {
        DAL_TKDN dal_tkdn = new DAL_TKDN();
        // Kiểm tra
        public bool Check_TKDN(string txtTenTK, string txtMK)
        {
            if (dal_tkdn.Check_TKDN(txtTenTK, txtMK))
            {
                return true;
            }
            return false;
        }
    }
}
