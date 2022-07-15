using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart.Models.Join
{
    public class Customer_info
    {
        public int num_id { get; set; }
        public long U_number { get; set; }
        public long U_altnumber { get; set; }
        public int type { get; set; }
        public string Cus_name { get; set; }
        public string Cus_gender { get; set; }
        public string Cus_email { get; set; }
    }
}