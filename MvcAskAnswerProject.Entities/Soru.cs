using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcAskAnswerProject.Entities
{
    [Table("Soru")]
    public class Soru:EntityBase
    {
        
        public string Baslik { get; set; }
        public string SoruIcerik { get; set; }

        public virtual Kullanici Kullanici { get; set; }
        public virtual Kategori Kategori { get; set; }
        public virtual List<Cevap> Cevaplar { get; set; }

        public Soru()
        {
            Cevaplar = new List<Cevap>();
        }

    }
}
