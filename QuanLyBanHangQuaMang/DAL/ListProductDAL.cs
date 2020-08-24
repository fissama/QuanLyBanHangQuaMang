using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHangQuaMang.DTO;
using Oracle.ManagedDataAccess.Client;
using System.Data;


namespace QuanLyBanHangQuaMang.DAL
{
    public class ListProductDAL
    {
        public static String constr = @"Data Source=(DESCRIPTION =
    (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))
    (CONNECT_DATA =
      (SERVER = DEDICATED)
      (SERVICE_NAME = XE)
    )
  );User Id=system;Password=161299";
        //public int lQty;
        public List<Product> lDAL;
        public ListProductDAL()
        {
            //ListProductBL lP = new ListProductBL();
            //this.lQty = Qty;
            this.lDAL = new List<Product>();
    
            OracleConnection con = new OracleConnection(constr);
            con.Open();

            // Execute a SQL SELECT
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from pttk.san_pham";
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable data = new DataTable();
                data.Load(dr);
                foreach (DataRow row in data.Rows)
                {
                    Product temp = new Product();
                    temp.PID = row[0].ToString();
                    temp.PName = row[1].ToString();
                    temp.PCategory = row[2].ToString();
                    temp.PCost = row[3].ToString();
                    temp.PQty = row[4].ToString();
                    temp.PImgUrl = row[5].ToString();
                    temp.PDetail = row[6].ToString();
                    this.lDAL.Add(temp);
                }
            }
            // Clean up
            dr.Dispose();
            cmd.Dispose();
            con.Dispose();
        }
    }
}
