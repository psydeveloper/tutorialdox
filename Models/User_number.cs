using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingCart.Models
{
    public class User_number
    {   
        [Key]
        public int num_id { get; set; }
        public long U_number { get; set; }

        public long U_altnumber { get; set; }

        public int type { get; set; } = 1;
    }
}