using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcAskAnswerProject.Entities
{
    [Table("Kullanici")]
    public class Kullanici : EntityBase
    {

        public string Email { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string ProfilResim { get; set; }
        public bool AdminMi { get; set; }


        public virtual List<Soru> Sorular { get; set; }
        public virtual List<Cevap> Cevaplar { get; set; }
        public virtual List<Kategori> Kategoriler { get; set; }

        public Kullanici()
        {
            Sorular = new List<Soru>();
            Cevaplar = new List<Cevap>();
            Kategoriler = new List<Kategori>();

        }
    }
}
