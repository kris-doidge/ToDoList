using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoList.Core.Interfaces;

namespace ToDoList.Core.Types
{
    public abstract class BaseRepo<TEntityType> : IBaseRepo<TEntityType> where TEntityType : BaseRootEntity
    {
        public virtual Task Delete(TEntityType entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task DeleteById(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual Task Create(TEntityType entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task<List<TEntityType>> Find(TEntityType type)
        {
            throw new NotImplementedException();
        }
    }
}