using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Kafe.Model.Entity
{
    public class Masa:BaseEntity,IBaseDomain
    {
        public int ID { get; set; }
        public string MasaAdi { get; set; }
        public int? UrunID { get; set; }

        public Urun MasaUrun { get; set; }
        public List<Adisyon> MasaAdisyon { get; set; }




    }
}
