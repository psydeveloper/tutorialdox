using Newtonsoft.Json;
using ShoppingCart.Models;
using ShoppingCart.Models.Join;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCart.Controllers
{
    public class Customer_infoController : Controller
    {
        // GET: Customer_info
        ShopDB db = new ShopDB();
        public dynamic info()
        {

            var result = (from a in db.user_number
                          join b in db.customers on a.num_id equals b.Cust_num_id
                          select new Customer_info
                          {
                              num_id = a.num_id,
                              U_number = a.U_number,
                              U_altnumber = a.U_altnumber,
                              type = a.type,
                              Cus_name = b.Cus_name,
                              Cus_gender = b.Cus_gender,
                              Cus_email = b.Cus_email
                          }
                          ).ToList();
            var data = JsonConvert.SerializeObject(result);
            return data;

        }
    }
}