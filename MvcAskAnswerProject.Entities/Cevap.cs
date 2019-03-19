using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcAskAnswerProject.Entities
{
    [Table("Cevap")]
    public class Cevap : EntityBase
    {
        [Required(ErrorMessage = ""),
            Display(Name = "Başlık"),
            StringLength(100, ErrorMessage = "{0} alanı {1} karakterden fazla olamaz")]
        public string Baslik { get; set; }

        [Required(ErrorMessage = ""),
            Display(Name = "CevapIcerik")]
        public string CevapIcerik { get; set; }

        public virtual Kullanici Kullanici { get; set; }
        public virtual Soru Soru { get; set; }


    }
}
