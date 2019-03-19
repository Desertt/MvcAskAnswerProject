using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcAskAnswerProject.Entities
{
    [Table("Soru")]
    public class Soru : EntityBase
    {
        [Required(ErrorMessage = "Başlık Alanı Boş Geçilemez")
        , Display(Name = "Başlık"), StringLength(100, ErrorMessage = "Başlık Alanı 100 Karakterden Fazla Olmamalıdır !")]
        public string Baslik { get; set; }

        [Required(ErrorMessage = "İçerik Alanı Boş Geçilemez")
            , Display(Name = "İçerik")]
        public string SoruIcerik { get; set; }

        [Display(Name = "Kategori")]
        public int KategoriId { get; set; }

        public virtual Kullanici Kullanici { get; set; }
        public virtual Kategori Kategori { get; set; }
        public virtual List<Cevap> Cevaplar { get; set; }

        public Soru()
        {
            Cevaplar = new List<Cevap>();
        }

    }
}
