using RBD.Data;
using System;
using System.Collections.Generic;

namespace RBD.BusinesLogic
{
    public interface IGenericService<TEntity> where TEntity : class, IEntity
    {
        void Create(TEntity item);
        void Delete(int id);
        TEntity GetItem(int id);
        IEnumerable<TEntity> GetItems();
        IEnumerable<TEntity> GetItems(Func<TEntity, bool> func);
        void Update(int id, TEntity item);
    }
}