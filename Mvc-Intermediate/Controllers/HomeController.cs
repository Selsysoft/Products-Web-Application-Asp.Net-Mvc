using Mvc_Intermediate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Intermediate.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            /*
            CONTEXT c = new CONTEXT();
            var degerler = c.Uruns.ToList();
            */
            
            
            
            UrunKategoriModel model = new UrunKategoriModel();

            model.UrunSayisi = Veritabani.Liste.Where(i => i.Satistami == true).Count();
            model.Urunler = Veritabani.Liste.Where(i => i.Satistami == true).ToList();

            //ViewBag.UrunSayisi = urunler.Count();
            //ViewBag.Kategoriler = kategoris;

            return View(model);
        }

        public ActionResult Details(int id)
        {
           var urun = Veritabani.Liste.Where(i => i.UrunId == id).FirstOrDefault();
            
            return View(urun);
        }
        public ActionResult Contact()
        {
            return View();
        }
        [HttpGet]
        public ActionResult UrunEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UrunEkle(Urun entity)
        {
            Veritabani.ElemanEkle(entity);

            return View("UrunListe", Veritabani.Liste);
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Phone()
        {
            UrunKategoriModel model = new UrunKategoriModel();

            model.UrunSayisi = Veritabani.Liste.Where(i => (i.Satistami == true && i.Turu == "Telefon")).Count();
            model.Urunler = Veritabani.Liste.Where(i => (i.Satistami == true && i.Turu == "Telefon")).ToList();
            return View(model);
        }
        public ActionResult Computer()
        {
            UrunKategoriModel model = new UrunKategoriModel();

            model.UrunSayisi = Veritabani.Liste.Where(i => (i.Satistami == true && i.Turu == "Bilgisayar")).Count();
            model.Urunler = Veritabani.Liste.Where(i => (i.Satistami == true && i.Turu == "Bilgisayar")).ToList();
            return View(model);
        }
        public ActionResult Tablet()
        {
            UrunKategoriModel model = new UrunKategoriModel();

            model.UrunSayisi = Veritabani.Liste.Where(i => (i.Satistami == true && i.Turu == "Tablet")).Count();
            model.Urunler = Veritabani.Liste.Where(i => (i.Satistami == true && i.Turu == "Tablet")).ToList();
            return View(model);
        }
        public ActionResult Accessory()
        {
            UrunKategoriModel model = new UrunKategoriModel();

            model.UrunSayisi = Veritabani.Liste.Where(i => (i.Satistami == true && i.Turu == "Aksesuar")).Count();
            model.Urunler = Veritabani.Liste.Where(i => (i.Satistami == true && i.Turu == "Aksesuar")).ToList();
            
            return View(model);
        }
    }
}