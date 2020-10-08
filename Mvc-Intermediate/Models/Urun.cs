using FsCheck;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc_Intermediate.Models
{
    public class Urun
    {

        /*[Key]*/
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public string Aciklama { get; set; }
        public double Fiyat { get; set; }
        public bool Satistami { get; set; }
        public string Resim { get; set; }
        public string Turu { get; set; }


    }
}