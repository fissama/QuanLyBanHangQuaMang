using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Client;
using QuanLyBanHangQuaMang.DTO;
using QuanLyBanHangQuaMang.BLL;

namespace QuanLyBanHangQuaMang.DAL
{

    public class GioHangDAL
    {
        public GioHangBLL gH = new GioHangBLL();


        public void GhiGioHang(GioHangBLL gh)
        {
            List<ProductBLL> lp = new List<ProductBLL>();
            foreach (var el in gh.idSP)
            {
                lp.Add(new ProductBLL(el));
            }
            int total = 0;
            int count = 0;
            foreach (var el in lp)
            {
                total = Convert.ToInt32(el.pBLL.pDAL.PCost) * gh.qtySP[count];
                count++;
            }
            //Product iProduct = new Product();
            String constr = @"Data Source=(DESCRIPTION =
    (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-E7O6VVM)(PORT = 1521))
    (CONNECT_DATA =
      (SERVER = DEDICATED)
      (SERVICE_NAME = XE)
    )
  );User Id=system;Password=161299";
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            int maxId = 0;
            // Execute a SQL SELECT
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "select max(MaHD) from pttk.hoa_don";
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable data = new DataTable();
                data.Load(dr);
                foreach (DataRow row in data.Rows)
                {
                    maxId = Convert.ToInt32(row[0].ToString());
                }
            }
            string cmdText = "insert into pttk.hoa_don values(" + (maxId + 1).ToString() + ",TO_DATE(SYSDATE, 'MM-DD-YYYY'," + "1,1,1," + total.ToString() + ",Dang giao)";
            cmd.CommandText = cmdText;
            dr = cmd.ExecuteReader();
            // Clean up
            dr.Dispose();
            cmd.Dispose();
            con.Dispose();
        }
    }
}
