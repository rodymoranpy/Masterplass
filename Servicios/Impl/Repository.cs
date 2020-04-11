using Modelo.Interfaces;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Impl
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext db;

        public Repository()
        {
            db = new masterplasEntities();
        }
        //Para usar con los managers y no tener que hacer attach dettach
        public Repository(DbContext _db)
        {
            db = _db;
        }
        public IEnumerable<T> FindAll()
        {
            return db.Set<T>().ToList<T>();
        }
        public T FindById(string id)
        {
            return db.Set<T>().Find(id);
        }
        public T Create(T obj)
        {
            return db.Set<T>().Add(obj);
        }
        public bool Update(T obj)
        {
            bool R;
            try
            {
                db.Entry(obj).State = EntityState.Modified;
                R = true;
            }
            catch (Exception ex)
            {
                R = false;
            }
            return R;
        }
        public bool Delete(string id)
        {
            bool R;
            try
            {
                T obj = db.Set<T>().Find(id);
                db.Set<T>().Remove(obj);
                R = true;
            }
            catch (Exception ex)
            {
                R = false;
            }
            return R;
        }

        public void Save()
        {
            db.SaveChanges();
            db.Dispose();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
