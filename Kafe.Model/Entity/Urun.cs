using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafe.Model.Entity
{
    public class Urun:BaseEntity,IBaseDomain
    {
        public int ID { get; set; }
        public string UrunAdi { get; set; }
        public decimal? Ucreti { get; set; }
        public string NasilYapilir { get; set; }
        public string Resim { get; set; }
        public string UrunBoyutu { get; set; }

        public int? KategoriID { get; set; }

        public List<Kategori> UrunKategori { get; set; }
        public List<Masa> UrunMasa { get; set; }
        public List<Adisyon> UrunAdisyon { get; set; }


    }
}
