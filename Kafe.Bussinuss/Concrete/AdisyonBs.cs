using Kafe.Bussinuss.Abstract;
using Kafe.DataAccsess.Abstact;
using Kafe.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kafe.Bussinuss.Concrete
{
    public class AdisyonBs : IAdisyonBs
    {
        IAdisyonRepository repo;
        public AdisyonBs(IAdisyonRepository _repo)
        {
            repo = _repo;    
        }
        public void Delete(Adisyon entity)
        {
            repo.Delete(entity);
        }

        public Adisyon Get(Expression<Func<Adisyon, bool>> filter = null, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<Adisyon> GetAll(Expression<Func<Adisyon, bool>> filter = null, params string[] includelist)
        {
           return repo.GetAll(filter, includelist);
        }

        public void Insert(Adisyon entity)
        {
           repo.Insert(entity);
        }

        public void Update(Adisyon entity)
        {
            repo.Update(entity);
        }
    }
}
