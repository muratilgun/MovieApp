using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Controllers
{
    public class UserController : Controller
    {
        public IActionResult CreateUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateUser(UserModel model)
        {


            return View();
        }
        [AcceptVerbs("GET","POST")] /*Remote Attribute Kullanımına örnek üzerinde daha çalışılacak*/
        public IActionResult VerifyUserName(string UserName)
        {
            var users = new List<string> { "deneme", "deneme2" };
            if (users.Any(i => i == UserName))
            {
                return Json("Bu kullanıcı ismi daha önce alınmıştır");
            }
            return Json(true);
        }
    }
}
