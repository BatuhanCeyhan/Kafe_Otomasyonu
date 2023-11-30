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
    public class MasaBs : IMasaBs
    {
        IMasaRepository repo;

        public MasaBs(IMasaRepository _repo)
        {
            repo= _repo;
        }

        public void Delete(Masa entity)
        {
           repo.Delete(entity);
        }

        public Masa Get(Expression<Func<Masa, bool>> filter , params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<Masa> GetAll(Expression<Func<Masa, bool>> filter = null, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public void Insert(Masa entity)
        {
            repo.Insert(entity);
        }

        public void Update(Masa entity)
        {
            repo.Update(entity);
        }
    }
}
