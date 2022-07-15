using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingCart.Models
{
    public class Customer
    {   
        [Key]
        public int Cus_id { get; set; }
        public string Cus_name { get; set; }
        public string Cus_gender { get; set; }
        public string Cus_email { get; set; }
        public int Cust_num_id { get; set; }
    }
}