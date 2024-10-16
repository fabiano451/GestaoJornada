using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Jornada.contracts.IRepository
{
     public interface IBaseRepository<T> where T : class
    {
        T GetAll();
        T FindById(int id);
        T FindByName(string name);
        T Insert(T entity);
        T Update(T entity);
        void Delete(int id);
        T GetById(int id);
        List<T> InsertRange(List<T> entities);

        IList<T> Find(Expression<Func<T, bool>> predicate);
        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();

    }
}
