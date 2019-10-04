using Remotion.Linq.Clauses;
using ToDoList.Core.Types;

namespace ToDoList.Core.Interfaces
{
    public interface IBuilder<out TEntityType, in TDtoType> where TEntityType : BaseRootEntity where TDtoType : class
    {
        #region Public Methods

        TEntityType Build();
        IBuilder<TEntityType, TDtoType> FromDto(TDtoType dto);

        #endregion
    }
}