using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingCart.Models
{
    public class Country_info
    {   
        [Key]
        public int Id { get; set; }
        public string City_name { get; set; }
        public string Area { get; set; }
        public int Pincode{ get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public string country{ get; set; }
        public int Phone_code { get; set; }
        public string iso2 { get; set; }
    }
}