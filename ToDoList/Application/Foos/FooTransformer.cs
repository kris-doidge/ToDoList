using ToDoList.Core.Interfaces;
using ToDoList.Core.Types;
using ToDoList.Domain.Foos;

namespace ToDoList.Application.Foos
{
    public class FooTransformer : ITransformer<Foo,FooDto>
    {
        public FooDto ToDto(Foo entity)
        {
            FooDto dto = new FooDto();
            dto.Id = entity.Id;
            dto.CreateDate = entity.CreateDate;
            dto.Foos = entity.Foos;

            return dto;
        }
    }
}