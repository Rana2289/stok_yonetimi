using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sdasd.Models;
using System.Web.Security;

namespace sdasd.Controllers
{
    [CustomActionFilter]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // Login işlemini yaptığım yer
        public ActionResult Alogin(users userForm)
        {
            using(market_yonetimiiEntities1 db = new market_yonetimiiEntities1() )
            {
                var kullaniciVarMi = db.users.FirstOrDefault(
                    x => x.name == userForm.name && x.password == userForm.password
                    );
                if(kullaniciVarMi != null)
                {
                    // eğer kullanıcı var ise SatislarController dosyasındaki Index fonksiyonun çalıştıracak.
                    FormsAuthentication.SetAuthCookie(kullaniciVarMi.name, false);
                    return RedirectToAction("/index", "satislar");
                }
                // Eğer yoksa Index sayfasına dönüp hata mesajını gönderecektir.
                ViewBag.Hata = "Kullacını adı veya parola hatalı"; 
                return View("index");
            }
        }
    }
}