using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcAskAnswerProject.Entities
{
    public class EntityBase
    {
        public int Id { get; set; }
        public bool AktifMi { get; set; }
        public DateTime EklemeTarihi { get; set; }
        public DateTime DuzenlemeTarihi { get; set; }
        public string EkleyenKullanici { get; set; }
        public string DuzenleyenKullanici { get; set; }
    }
}
