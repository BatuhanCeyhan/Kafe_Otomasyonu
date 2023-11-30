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
    public class KategoriBs : IKategoriBs
    {
        IKategoriRepository repo;
        public KategoriBs(IKategoriRepository _repo)
        {
            repo = _repo;
        }

        public void Delete(Kategori entity)
        {
            repo.Delete(entity);
        }

        public Kategori Get(Expression<Func<Kategori, bool>> filter = null, params string[] includelist)
        {
           return repo.Get(filter, includelist);
        }

        public List<Kategori> GetAll(Expression<Func<Kategori, bool>> filter = null, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public void Insert(Kategori entity)
        {
            repo.Insert(entity);
        }

        public void Update(Kategori entity)
        {
           repo.Update(entity);
        }
    }
}
