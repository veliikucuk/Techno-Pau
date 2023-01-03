﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TechnoPau.Models.Sınıflar
{
    public class KargoDetay
    {
        [Key]
        public int KargoDetayID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Aciklama { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string TakipKodu { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Personel { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Alici { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(11)]
        public string TelNo { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Adres { get; set; }
        public DateTime Tarih { get; set; }
        
    }
}