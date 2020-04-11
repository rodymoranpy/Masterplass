using Servicios.Impl;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Servicios.Managers
{
    public class PaisManager
    {
        protected readonly DbContext db;
        protected Repository<paises> repo;

        public PaisManager()
        {
            db = new masterplasEntities();
            repo = new Repository<paises>(db);
        }

        public paises Create(paises p)
        {   
            paises R = repo.Create(p);
            repo.Save();

            return R;
        }

        public bool Update(paises p)
        {
            bool R = repo.Update(p);
            repo.Save();
            return R;
        }

        public void Remove(paises p)
        {
            repo.Delete(p.codigo);
        }

        public IEnumerable<paises> FindAll()
        {
            return repo.FindAll();
        }

        public paises FindById(paises p)
        {
            return repo.FindById(p.codigo);
        }
    }
}
