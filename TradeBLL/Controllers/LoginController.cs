using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TradeBLL.Models;
using TradeBLL.TradeTrackerService;
using TradeDAL;

namespace TradeBLL.Controllers
{

    public class LoginController : Controller
    {
       // Login loginService = new Login();
        public string Login(Models.LoginBLL login)
        {
            //TradeTrackerService.Login loginService = new TradeTrackerService.Login();

            Login loginService = new Login();
            loginDALModel loginDal = new loginDALModel();//need to pass the parameter to method
            loginDal.NIC = login.NIC;
            loginDal.Password = login.Password;


           string loginResult= loginService.GetLoginDetail(loginDal);
           return loginResult;
           //return View();
           //TempData["result"] = loginResult;
           //return RedirectToAction("Login", "Home", loginResult);
        }

        public ActionResult Register(Models.LoginBLL register) 
        {

            Login loginService = new Login();
            loginDALModel registerDal = new loginDALModel();

            registerDal.NIC = register.NIC;
            registerDal.Password = register.Password;
            loginService.RegisterUser(registerDal);

            return View();
        }

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
