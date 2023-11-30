using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafe.Model.Entity
{
    public class Kategori:BaseEntity,IBaseDomain
    {
        public int ID { get; set; }
        public string KategoriAdi { get; set; }
        public int AltKategoriID { get; set; }

        public Urun KategoriUrun { get; set; }

    }
}
