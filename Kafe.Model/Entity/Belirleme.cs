using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafe.Model.Entity
{
    public class Belirleme:BaseEntity,IBaseDomain
    {
        public int ID { get; set; }
        public string RolAdi { get; set; }
        public Kullanici BelirlemeKullanici { get; set; }
    }
}
