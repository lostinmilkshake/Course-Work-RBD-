using RBD.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RBD.BusinesLogic
{
    public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class, IEntity
    {
        private readonly Data.IGenericRepository<TEntity> _repository;

        public GenericService(Data.IGenericRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public TEntity GetItem(int id) => _repository.GetEntity(id);
        public IEnumerable<TEntity> GetItems() => _repository.GetEntities().ToList();
        public IEnumerable<TEntity> GetItems(Func<TEntity, bool> func) => _repository.GetEntities(func).ToList();
        public void Create(TEntity item) => _repository.Create(item);
        public void Update(int id, TEntity item) => _repository.Update(id, item);
        public void Delete(int id) => _repository.Remove(id);
    }
}
