using Core.DataAccess.Concrate.EntityFramework;
using Kafe.DataAccsess.Abstact;
using Kafe.DataAccsess.Concrete.Entity_Framework.Context;
using Kafe.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafe.DataAccsess.Concrete.Entity_Framework.Respository
{
    public class EfUrunRepository:EfRepositoryBase<Urun,KafeDbContext>,IUrunRepository
    {
    }
}
