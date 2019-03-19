using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcAskAnswerProject.Entities
{
    public class EntityBase
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name ="Aktif Mi ? ")]
        public bool AktifMi { get; set; }

        [Display(Name = "Ekleme Tarihi")]
        public DateTime EklemeTarihi { get; set; }

        [Display(Name = "Düzenleme Tarihi")]
        public DateTime DuzenlemeTarihi { get; set; }

        [Display(Name = "Ekleyen Kullanici")]
        public string EkleyenKullanici { get; set; }

        [Display(Name = "Düzenleyen Kullanici")]
        public string DuzenleyenKullanici { get; set; }
    }
}
