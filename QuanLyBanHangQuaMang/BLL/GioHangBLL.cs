using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHangQuaMang.DTO;
using Oracle.ManagedDataAccess.Client;
using System.Data;


namespace QuanLyBanHangQuaMang.BLL
{
    public class GioHangBLL
    {
        public List<int> idSP = new List<int>();
        public List<int> qtySP = new List<int>();
        private static GioHangBLL instance;
        public static GioHangBLL Instance
        {
            get
            {
                if (instance == null) instance = new GioHangBLL();
                return GioHangBLL.instance;
            }
            private set { GioHangBLL.instance = value; }
        }
        public void addGioHang(int Qty, int id)
        {
            idSP.Add(id);
            qtySP.Add(Qty);
        }

        public bool checkId(int Qty, int id)
        {
            int count = 0,flat =0;
            foreach(var el in idSP)
            {
                count++;
                if (el == id)
                {
                    flat = 1;
                    break;
                }
            }
            if (flat == 1)
            {
                qtySP[count - 1] = qtySP[count - 1] + Qty;
                return true;
            }
            return false;

        }

    }
}
