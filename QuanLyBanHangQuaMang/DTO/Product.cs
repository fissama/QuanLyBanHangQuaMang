using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangQuaMang.DTO
{
    public class Product
    {
        private String pID;
        public string PID { get => pID; set => pID = value; }

        private String pName;
        public string PName { get => pName; set => pName = value; }

        private String pCategory;
        public string PCategory { get => pCategory; set => pCategory = value; }

        private String pCost;
        public string PCost { get => pCost; set => pCost = value; }

        private String pQty;
        public string PQty { get => pQty; set => pQty = value; }

        private String pImgUrl;
        public string PImgUrl { get => pImgUrl; set => pImgUrl = value; }

        private String pDetail;
        public string PDetail { get => pDetail; set => pDetail = value; }

        public Product() { }
    }
}
