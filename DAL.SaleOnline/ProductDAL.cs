using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Client;

namespace DAL.SaleOnline
{
    class ProductDAL
    {
        public String pID
        {
            get { return pID; }
            set { pID = value; }
        }

        public String pName
        {
            get { return pName; }
            set { pName = value; }
        }

        public String pCategory
        {
            get { return pCategory; }
            set { pCategory = value; }
        }

        public float pCost
        {
            get { return pCost; }
            set { pCost = value; }
        }

        public int pQty
        {
            get { return pQty; }
            set { pQty = value; }
        }

        public String pImgUrl
        {
            get { return pImgUrl; }
            set { pImgUrl = value; }
        }

        public ProductDAL() { }

        public ProductDAL LoadProduct(int i)
        {
            ProductDAL iProduct = new ProductDAL();
            String constr = @"Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE)));
                              User Id=pttk;Password=1";
            OracleConnection con = new OracleConnection(constr);
            con.Open();

            // Execute a SQL SELECT
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from pttk.san_pham where rownum =" + i.ToString() + ";";
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable schemaTable = dr.GetSchemaTable();
                DataTable data = new DataTable();
                foreach (DataRow row in schemaTable.Rows)
                {
                    iProduct.pID = row["MaSP"].ToString();
                    iProduct.pName = row["TenSP"].ToString();
                    iProduct.pCategory = row["LoaiSP"].ToString();
                    iProduct.pCost = (float)row["Gia"];
                    iProduct.pQty = (int)row["SLTon"];
                    iProduct.pImgUrl = row["ImgUrl"].ToString();
                }
            }
            // Clean up
            dr.Dispose();
            cmd.Dispose();
            con.Dispose();
            return iProduct;
        }
    }
}
