using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoList.Core.Types;

namespace ToDoList.Core.Interfaces
{
    public interface IBaseRepo<TEntityType>  where TEntityType : BaseRootEntity
    {
        #region Public Methods

        //Task TryFindById();
        Task Delete(TEntityType entity);
        Task DeleteById(Guid id);
        Task Create(TEntityType entity);
        Task<List<TEntityType>> Find(TEntityType type);
        //Task ListAll();

        #endregion
    }
}