using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Repositories
{
    public interface IRepository<T> where T : class
    {
        T get(int id);
        IEnumerable<T> GetAll();
        T add(T entity);
        T Update(T entity);
        T Delete(int id);  
    }
}
