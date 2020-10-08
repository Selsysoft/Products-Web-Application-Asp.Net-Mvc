using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_Intermediate.Models
{
    public static class Veritabani
    {
        private static List<Urun> _liste;

        static Veritabani()
        {
            
            _liste = new List<Urun>()
            {
            new Urun() { UrunId =1, UrunAdi="Samsung S9", Aciklama="Telefon", Fiyat=3000, Turu= "Telefon", Satistami=true, Resim="1.jpg"},
            new Urun() { UrunId =2, UrunAdi="Samsung S10 PLUS", Aciklama="Telefon", Fiyat=3000, Turu= "Telefon", Satistami=true, Resim="2.jpg"},
            new Urun() { UrunId =3, UrunAdi="IPhone 7", Aciklama="Telefon", Fiyat=3000, Turu= "Telefon", Satistami=true, Resim="3.jpg"},
            new Urun() { UrunId =4, UrunAdi="Casper Nirvana", Aciklama="Notebook", Fiyat=3000, Turu= "Bilgisayar", Satistami=true, Resim="4.jpg"},
            new Urun() { UrunId =5, UrunAdi="Samsung", Aciklama="Tablet", Fiyat=3000, Turu= "Tablet", Satistami=true, Resim="5.jpg"},
            new Urun() { UrunId =6, UrunAdi="Huawei", Aciklama="Tablet", Fiyat=3000, Turu= "Tablet", Satistami=true, Resim="6.jpg"},
            new Urun() { UrunId =7, UrunAdi="Kulaklık", Aciklama="Kulaklık", Fiyat=3000, Turu= "Aksesuar", Satistami=true, Resim="7.jpg"},
            new Urun() { UrunId =8, UrunAdi="Usb Bellek", Aciklama="Usb Bellek", Fiyat=3000, Turu= "Aksesuar", Satistami=true, Resim="8.jpg"}

            };
        }
        public static List<Urun> Liste
        {
            get { return _liste; }
        }
        public static void ElemanEkle (Urun entity)
        {
            _liste.Add(entity);
        }
        public static Urun UrunDetay(int urunid)
        {
            Urun entity = null;
            foreach (var urun in _liste)
            {
                if (urun.UrunId == urunid)
                {
                    entity = urun;
                }
            }
            return entity;
        }
    }
}