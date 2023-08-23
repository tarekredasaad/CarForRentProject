using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data.Repository;

public class Repository<T> : IRepository<T> where T : Base
{
    Context _context;
    public Repository(Context context)
    {
        _context = context;
    }

    public IQueryable<T> GetAll()
    {
        return _context.Set<T>();//.Where(x=> !x.Deleted);
    }

    public IQueryable<T> GetAll(string property)
    {
        return _context.Set<T>().Include(property);
    }

    public IQueryable<T> GetAll(string property1, string property2)
    {
        return _context.Set<T>().Include(property1).Include(property2);
    }


  
    public IQueryable<T> GetAll(Expression<Func<T, bool>> expression)
    {
        return _context.Set<T>().Where(expression);
    }

    //public IQueryable<T> Get(Expression<Func<T, bool>> expression)
    //{
    //    return _context.Set<T>().Where(expression);
    //}

    public T create(T t)
    {
        _context.Set<T>().Add(t);
        _context.SaveChanges();
        return t;
    }

   


    public void SaveChanges()
    {
        _context.SaveChanges();
    }

    
}
