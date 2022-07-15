using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

namespace ShoppingCart.Controllers
{
  
    public class LoginController : Controller
    {
        // GET: Login
        ShopDB db = new ShopDB();
        
        public dynamic Adduser(User_number u)
        {
            string msg;
            int count = (int)u.U_number;
            int numcount = count.ToString().Count();

            try
            {
                if(numcount == 10)
                {
                    db.user_number.Add(u);
                    db.SaveChanges();
                    msg = "success";
                }
                else
                {
                    msg = " Number is not valid";
                }
            }
            catch (Exception)
            {

                msg = "already exist";
            }
            return msg;
            
        }

        public dynamic updateuser(User_number u)
        {
            var _db = db.user_number.Find(u.num_id);
            if (u.U_number != _db.U_number)
            {
                _db.U_number = u.U_number;
            }
            else if (u.U_altnumber != _db.U_altnumber)
            {
                _db.U_altnumber = u.U_altnumber;

            }
            else
            {
                return "This number already match with previous";
            }
            db.Entry(_db).State = System.Data.EntityState.Modified;
            db.SaveChanges();
            return "success";

        }

      
    }
}