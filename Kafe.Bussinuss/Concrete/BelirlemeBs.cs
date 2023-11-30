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
    public class BelirlemeBs : IBelirlemeBs
    {
        IBelirlemeRepository repo;
        public BelirlemeBs(IBelirlemeRepository _repo)
        {
            repo = _repo;
        }
        public void Delete(Belirleme entity)
        {
            repo.Delete(entity);
        }

        public Belirleme Get(Expression<Func<Belirleme, bool>> filter = null, params string[] includelist)
        {
           return repo.Get(filter, includelist);
        }

        public List<Belirleme> GetAll(Expression<Func<Belirleme, bool>> filter = null, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public void Insert(Belirleme entity)
        {
            repo.Insert(entity);
        }

        public void Update(Belirleme entity)
        {
            repo.Update(entity);
        }
    }
}
