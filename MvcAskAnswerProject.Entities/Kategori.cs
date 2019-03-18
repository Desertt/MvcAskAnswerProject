using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcAskAnswerProject.Entities
{
    [Table("Kategori")]
    public class Kategori:EntityBase
    {

        public string Baslik { get; set; }
        public string Aciklama { get; set; }

        public virtual List<Soru> Sorular { get; set; }
        public virtual Kullanici Kullanici { get; set; }

        public Kategori()
        {
            Sorular = new List<Soru>();
        }
    }
}
