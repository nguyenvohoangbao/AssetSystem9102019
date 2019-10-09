using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AssetSystem01.Models;
using AssetSystem01.Data;
using AssetSystem01.Common;
using AssetSystem01.ViewModel;
using Microsoft.AspNetCore.Http;

namespace AssetSystem01.Controllers
{
    public class AccountController : Controller
    {
        private readonly AssetSystemDbContext _assetSystemDbContext;
        public AccountController(AssetSystemDbContext assetSystemDbContext)
        {
            _assetSystemDbContext = assetSystemDbContext;

        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                var result = _assetSystemDbContext.Users.Where(x => x.UserName == model.UserName && x.PassWord ==
                Crypto.Encrypt(model.PassWord)).FirstOrDefault();
                if (result != null) //có dữ liệu
                {
                    HttpContext.Session.SetString("UserName", result.Name);
                    return RedirectToAction("Index","Admin");
                }
                else
                {
                    return View("Login", new LoginViewModel());
                }
                
            }

            return View("Login", new LoginViewModel());
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if(ModelState.IsValid)
            {
                var obj = new User();
                obj.Name = model.Name;
                obj.UserName = model.UserName;
                obj.PassWord = Crypto.Encrypt(model.PassWord);
                _assetSystemDbContext.Add(obj);
                _assetSystemDbContext.SaveChanges();
                return RedirectToAction("Login","Account");
            }
            else
            {
                return View("Register",new RegisterViewModel());
            }

        }
       

        
    }
}
