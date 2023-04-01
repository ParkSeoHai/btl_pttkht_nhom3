using DAL_BHQA;
using DTO_BHQA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_BHQA
{
    public class BUS_QLKH
    {
        DAL_QLKH DAL_QLKH = new DAL_QLKH();

        // Lấy dữ liệu từ lớp DAL
        public DataTable getData()
        {
            return DAL_QLKH.getData();
        }

        public bool ThemKH()
        {
            if(DAL_QLKH.ThemKH())
            {
                return true;
            }
            return false;
        }
    }
}
