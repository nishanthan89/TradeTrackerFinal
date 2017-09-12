using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TradeBLL.Models;
using TradeTracker.Models;

namespace TradeTracker.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string NIC)
        {

            if (Session["loginUser"] == null)
            {

                // return Redirect("Index");
                return RedirectToAction("Login", "Home");
            }
            else
            {
                ViewBag.LoginUser = NIC;
                return View();
            }



            //HttpCookie logincookie = new HttpCookie(logincookie);
            //logincookie.Value = login.NIC;
           // string userName = login.NIC;
           // string userName = logincookie.Value;
           // ViewBag.LoginUser = userName;
           // ViewBag.LoginUser = HttpContext.User.Identity.Name;
            //return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            if(Session["loginUser"]!=null)
            {

               // return Redirect("Index");
                return RedirectToAction("Index", "Home", new { NIC = Session["loginUser"].ToString()});
            }
            else
            {
                return View();
            }
           
        }
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public string showLoginUser(Models.LoginModel login) 
        {
            string userName = login.NIC;
            ViewBag.LoginUser = userName;
            return ViewBag.LoginUser;
        }

        [HttpPost]
        public ActionResult Login(Models.LoginModel login)
        {
           // Task t = new Task();
            Session["loginUser"] = login.NIC;
           
            TradeBLL.Controllers.LoginController loginbll = new TradeBLL.Controllers.LoginController();
            TradeBLL.Models.LoginBLL loginmodel = new TradeBLL.Models.LoginBLL();

          //  loginmodel.Id = login.Id;
            loginmodel.NIC = login.NIC;
            loginmodel.Password = login.Password;
            string logdta = loginbll.Login(loginmodel).ToString();


            ViewBag.LoginResult = logdta;
            if (logdta == "Successfully login")
            {
                //return Redirect("Index");
                return RedirectToAction("Index", "Home", new { NIC = Session["loginUser"].ToString() });
            }
            else {
                return Redirect("Login");
            } 
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


        
    }
}
