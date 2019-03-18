using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcAskAnswerProject.Entities
{
    [Table("Cevap")]
    public class Cevap:EntityBase
    {
        
        public string Baslik { get; set; }
        public string CevapIcerik { get; set; }

        public virtual Kullanici Kullanici { get; set; }
        public virtual Soru Soru { get; set; }


    }
}
