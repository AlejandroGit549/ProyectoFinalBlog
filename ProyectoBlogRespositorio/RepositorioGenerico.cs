using Microsoft.EntityFrameworkCore;
using ProyectoBlogDatos.Data;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBlogRespositorio
{
    public class RepositorioGenerico<TEntity> : IRepositorioGenerico<TEntity> where TEntity : class 
    {
        private BlogContext _context;
        private DbSet<TEntity> _dbSet;

        public RepositorioGenerico(BlogContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>(); 
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(TEntity entity)
        {
           _dbSet.Remove(entity);
        }

        public TEntity? Get(int id)
        {
            return _dbSet.Find( id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> expresionLambda)
        {
           return _dbSet.Where(expresionLambda).ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
