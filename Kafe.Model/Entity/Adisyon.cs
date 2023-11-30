using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Kafe.Model.Entity
{
    public class Adisyon:BaseEntity,IBaseDomain
    {
        public int ID { get; set; }
        public int MasaID { get; set; }
        public int UrunID { get; set; }
        public decimal? TotalPara { get; set; }

        public Masa AdisyonMasa { get; set; }
        public Urun AdisyonUrun { get; set; }
    }
}
