using System;
using ToDoList.Core.Interfaces;
using ToDoList.Domain.Foos;

namespace ToDoList.Application.Foos
{
    public class FooBuilder : IBuilder<Foo, FooDto>
    {
        #region Properties

        public string Foos { get; set; }
        

        #endregion
        public Foo Build()
        {
            Foos = "Foo";
            Foo Foo = new Foo(Foos);
            return Foo;
        }

        public IBuilder<Foo, FooDto> FromDto(FooDto dto)
        {
            Foos = dto.Foos;
            return this;
        }
    }
}