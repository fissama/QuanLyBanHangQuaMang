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
    }
}
