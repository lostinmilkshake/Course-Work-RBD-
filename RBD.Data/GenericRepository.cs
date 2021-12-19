using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RBD.Data
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IEntity
    {
        private DbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(DbContext context)
        {
            _dbContext = context;
            _dbSet = context.Set<TEntity>();
        }

        public TEntity GetEntity(int id)
        {
            return _dbSet.AsNoTracking().FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<TEntity> GetEntities()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public IEnumerable<TEntity> GetEntities(Func<TEntity, bool> func)
        {
            return _dbSet.AsNoTracking().Where(func);
        }

        public void Create(TEntity entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(int id, TEntity entity)
        {
            _dbContext.ChangeTracker.Clear();

            entity.Id = id;

            _dbContext.Update(entity);
            _dbContext.SaveChanges();
        }

        public void Remove(int id)
        {
            var entity = _dbSet.Find(id);
            _dbSet.Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}
