using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TradeTracker.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Models.LoginModel login)
        {
           
            TradeBLL.Controllers.LoginController loginbll = new TradeBLL.Controllers.LoginController();
            TradeBLL.Models.LoginBLL loginmodel = new TradeBLL.Models.LoginBLL();

            loginmodel.Id = login.Id;
            loginmodel.NIC = login.NIC;
            loginmodel.Password = login.Password;

            loginbll.Login(loginmodel);

            return View();
        }

        public ActionResult SignUp(Models.LoginModel registerUser)
        {
            TradeBLL.Controllers.LoginController registerbll = new TradeBLL.Controllers.LoginController();
            TradeBLL.Models.LoginBLL registermodel = new TradeBLL.Models.LoginBLL();

            registermodel.NIC = registerUser.NIC;
            registermodel.Password = registerUser.Password;
            if (registerUser.Password == registerUser.RePassword)
            {
                registerbll.Register(registermodel);

            }
            else {
                ViewBag.Msg = "Password miss matched";
                //return View("Password miss matched");
               // alert("Password miss matched");
            }
            return View(); 
           
        }

        public ActionResult UserRegisterForm()
        {
            return View();
        }


        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
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

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
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

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
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
