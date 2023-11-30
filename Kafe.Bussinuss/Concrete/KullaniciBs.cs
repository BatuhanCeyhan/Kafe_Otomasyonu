using Kafe.DataAccsess.Abstact;
using Kafe.Bussinuss.Abstract;
using Kafe.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kafe.Bussinuss.Concrete
{
    public class KullaniciBs : IKullaniciBs
    {
        IKullaniciRepository repo;

        public KullaniciBs(IKullaniciRepository _repo)
        {
            repo = _repo;   
        }


        public void Delete(Kullanici entity)
        {
            repo.Delete(entity);
        }

        public Kullanici Get(Expression<Func<Kullanici, bool>> filter, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<Kullanici> GetAll(Expression<Func<Kullanici, bool>> filter = null, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public void Insert(Kullanici entity)
        {
            repo.Insert(entity);
        }

        public void Update(Kullanici entity)
        {
            repo.Update(entity);
        }
    }
}
