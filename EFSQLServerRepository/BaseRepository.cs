using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFSQLServerRepository
{
    public class BaseRepository<T> where T : class , IDisposable
    {
        protected Vehiculos05Entities Contexto = new Vehiculos05Entities();
        protected DbSet<T> DbSet;
        
        public BaseRepository()
        {
            DbSet = Contexto.Set<T>();
        }

        public void Insertar(T entidad)
        {
            DbSet.Add(entidad);
        }

        public void Eliminar(T entidad)
        {
            DbSet.Remove(entidad);
        }

        public IQueryable<T> Filtrar(Expression<Func<T, bool>> expresion)
        {
            return DbSet.Where(expresion);
        }

        public T ObtenerPorId(int id)
        {
            return DbSet.Find(id);
        }

        public IQueryable<T> ObtenerTodos()
        {
            return DbSet;
        }

        public void GuardarCambios()
        {
            Contexto.SaveChanges();
        }

        public void Dispose()
        {
            DbSet = null;
            Contexto.Dispose();
        }
    }
}
