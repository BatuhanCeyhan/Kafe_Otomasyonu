using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafe.Model.Entity
{
    public class Kullanici:BaseEntity,IBaseDomain
    {
        public int ID{ get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }

        public string  Resim { get; set; }

        public DateTime? IseBaslamaTarihi { get; set; }
        public decimal? Maas { get; set; }
        public string Notlar { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public int BelirlemeID { get; set; }

        public List<Belirleme> KullaniciBelirleme { get; set; }







    }
}
