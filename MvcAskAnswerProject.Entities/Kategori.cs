using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcAskAnswerProject.Entities
{
    [Table("Kategori")]
    public class Kategori : EntityBase
    {
        [Required(ErrorMessage = "{0} alannı boş geçilemez"),
            Display(Name = "Başlık"),
            StringLength(100, ErrorMessage = "{0} alanı {1} karakterden fazla olamaz")]
        public string Baslik { get; set; }

        [Required(ErrorMessage = "{0} alannı boş geçilemez"),
            Display(Name = "Açıklama"),
            StringLength(150, ErrorMessage = "{0} alanı {1} karakterden fazla olamaz")]
        public string Aciklama { get; set; }

        public virtual List<Soru> Sorular { get; set; }
        public virtual Kullanici Kullanici { get; set; }

        public Kategori()
        {
            Sorular = new List<Soru>();
        }
    }
}
