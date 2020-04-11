using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> FindAll();
        T FindById(string id);
        T Create(T obj);
        bool Update(T obj);
        bool Delete(string id);
        void Save();
        void Dispose();
    }
}
