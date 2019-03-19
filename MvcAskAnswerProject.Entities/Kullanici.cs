using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcAskAnswerProject.Entities
{
    [Table("Kullanici")]
    public class Kullanici : EntityBase
    {
        [Required(ErrorMessage = "{0} alanı boş geçilemez"),
            Display(Name = "E-Mail"),
            StringLength(50, ErrorMessage = "{0} alanı {1} karakterden fazla olamaz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} alanı boş geçilemez"),
           Display(Name = "Adınız"),
           StringLength(20, ErrorMessage = "{0} alanı {1} karakterden fazla olamaz")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "{0} alanı boş geçilemez"),
           Display(Name = "Soyadınız"),
           StringLength(20, ErrorMessage = "{0} alanı {1} karakterden fazla olamaz")]
        public string Soyad { get; set; }

        [Required(ErrorMessage = "{0} alanı boş geçilemez"),
           Display(Name = "Kullanıcı Adı"),
           StringLength(50, ErrorMessage = "{0} alanı {1} karakterden fazla olamaz")]
        public string KullaniciAdi { get; set; }

        [Required(ErrorMessage = "{0} alanı boş geçilemez"),
           Display(Name = "Şifre"),
           StringLength(10, ErrorMessage = "{0} alanı {1} karakterden fazla olamaz")]
        public string Sifre { get; set; }


        [Display(Name = "Profil Resmi"),
        StringLength(30, ErrorMessage = "{0} alanı {1} karakterden fazla olamaz")]
        public string ProfilResim { get; set; }

        [Display(Name = "Yönetici Mi?")]
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
