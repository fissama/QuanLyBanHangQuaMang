using QuanLyBanHangQuaMang.DAL;
//using QuanLyBanHangQuaMang.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangQuaMang.BLL
{
    public class ProductBLL
    {
        public ProductDAL pBLL;

        public ProductBLL(int i)
        {
            this.pBLL = new ProductDAL(i);
        }

        public int checkQty(int iQty)
        {
            if (iQty > Convert.ToInt32(this.pBLL.pDAL.PQty))
                return 1;
            else if (iQty < 1)
                return -1;
            else if (Convert.ToInt32(this.pBLL.pDAL.PQty) == 0)
            { 
                return 2;
            }

            else return 0;

        }
        public static void checkName(int id, int sl)
        {
          
        }
    }
}
