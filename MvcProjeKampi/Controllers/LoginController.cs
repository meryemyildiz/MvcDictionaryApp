using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcProjeKampi.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
             [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
            [HttpPost]
        public ActionResult Index(Admin p)
        {
               Context c = new Context();
               var adminUserInfo = c.Admins.FirstOrDefault(x => x.AdminUserName == p.AdminUserName && x.AdminPassword == p.AdminPassword);
                if (adminUserInfo !=null)
            {
                FormsAuthentication.SetAuthCookie(adminUserInfo.AdminUserName, false); //cookie istemiyorum
                Session["AdminUserName"] = adminUserInfo.AdminUserName;
                return RedirectToAction("Index", "AdminKategori");
            }
            else
            {
                return RedirectToAction("Index");
            }
         }
        [HttpGet]
        public ActionResult WriterLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult WriterLogin(Writer p)
        {
            Context c = new Context();
            var writerUserInfo = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);
            if (writerUserInfo != null)
            {
                FormsAuthentication.SetAuthCookie(writerUserInfo.WriterMail, false); //cookie istemiyorum
                Session["WriterMail"] = writerUserInfo.WriterMail;
                return RedirectToAction("MyContent", "WriterPanelContent");
            }
            else
            {
                return RedirectToAction("WriterLogin");
            }
        }
    }
}
 //< customErrors mode = "On" >
 
 //          < error statusCode = "404" redirect = "/ErrorPage/Page404/" />
    
 //         </ customErrors >