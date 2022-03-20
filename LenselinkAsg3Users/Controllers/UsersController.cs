using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LenselinkAsg3Users.Models;
using System;

namespace LenselinkAsg3Users.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Detail(int id)
        {
            User user = DB.GetUserByID(id);
            return View(user);
        }

        [HttpPost]
        public IActionResult List(string id = "")
        {
            List<User> users;

            if (id.Trim() == "")
            {
                users = DB.GetUsers();
            }
            else
            {
                users = DB.GestUsersByLastName(id);
            }

            return View(users);
        }
    }
}
