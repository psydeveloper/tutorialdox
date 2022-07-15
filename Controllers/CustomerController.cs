using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCart.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        ShopDB db = new ShopDB();
        public dynamic AddCustomer(Customer c)
        {
            string msg;
            try
            {
                db.customers.Add(c);
                db.SaveChanges();
                msg = "success";
            }
            catch (Exception)
            {

                msg = "unsuccess";
            }
            return msg;
        }

        public dynamic updatecustomer(Customer c)
        {
            string msg;
            var _db = db.customers.Find(c.Cus_id);
            if(_db.Cus_name != c.Cus_name)
            {
                _db.Cus_name = c.Cus_name;
            }
           
            if (_db.Cus_gender != c.Cus_gender)
            {
                _db.Cus_gender = c.Cus_gender;
            }
            
            if (_db.Cus_email != c.Cus_email) {
                _db.Cus_email = c.Cus_email;
            }
            
            
            db.Entry(_db).State = System.Data.EntityState.Modified;
            db.SaveChanges();
            return "successfull update";
            
        }
    }
}