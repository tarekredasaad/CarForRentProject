using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Data.Repository
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
        IQueryable<T> GetAll(string property);
        IQueryable<T> GetAll(string property1, string property2);

        T create(T t);



        void SaveChanges();
    }
}
