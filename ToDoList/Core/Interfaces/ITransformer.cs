using ToDoList.Core.Types;

namespace ToDoList.Core.Interfaces
{
    public interface ITransformer<in TEntityType, out TDtoType>
    {
        TDtoType ToDto(TEntityType entity);
    }
}