
using WebApplication1.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data.UnitOfWork
{
    public interface IUnitOfWorkRepository 
    {
        IRepository<Car> Car { get; }
        //IRepository<Order> Order { get; }
    }
}
