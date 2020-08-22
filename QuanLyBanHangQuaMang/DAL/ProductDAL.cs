using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Client;
using QuanLyBanHangQuaMang.DTO;

namespace QuanLyBanHangQuaMang.DAL
{
    public class ProductDAL
    {
        public Product pDAL = new Product();

        public ProductDAL(int i)
        {
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

            // Execute a SQL SELECT
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from pttk.san_pham where MaSP =" + (i).ToString();
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable data = new DataTable();
                data.Load(dr);
                foreach (DataRow row in data.Rows)
                {
                    this.pDAL.PID = row[0].ToString();
                    this.pDAL.PName = row[1].ToString();
                    this.pDAL.PCategory = row[2].ToString();
                    this.pDAL.PCost = row[3].ToString();
                    this.pDAL.PQty = row[4].ToString();
                    this.pDAL.PImgUrl = row[5].ToString();
                    this.pDAL.PDetail = row[6].ToString();
                }
            }
            // Clean up
            dr.Dispose();
            cmd.Dispose();
            con.Dispose();
        }
    }
}
