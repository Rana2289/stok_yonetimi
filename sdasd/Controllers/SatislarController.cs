using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sdasd.Models;

namespace sdasd.Controllers
{
    [CustomActionFilter]
    public class SatislarController : Controller
    {
        [Route("satislar")]
        // GET: Satislar
        public ActionResult Index()
        {
            using (market_yonetimiiEntities1 db = new market_yonetimiiEntities1())
            {
                // Toplam satış hesaplaması
                ViewBag.toplamSatis = db.musteriler.Sum(s => s.satis_miktari);

                // kullanıcıları döndüğüm yer
                var musteriListesi = db.musteriler.ToList();
                return View(musteriListesi);
            }
        }

        // ekleme sayfasını acan fonksiyon
        public ActionResult EklemeSayfasi()
        {
            return View();

        }

        // Ekleme işlemini yapıp listelemeye dönen yer
        public ActionResult Ekle(musteriler musteri)
        {
            using (market_yonetimiiEntities1 db = new market_yonetimiiEntities1())
            {
                db.musteriler.Add(musteri);
                db.SaveChanges();
            }
            return RedirectToAction("/index", "satislar");
        }
    }
}