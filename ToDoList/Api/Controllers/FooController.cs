using SharpCompress.Common.Tar;
using ToDoList.Api.Types;
using ToDoList.Application.Foos;
using ToDoList.Core.Interfaces;
using ToDoList.Domain.Foos;
using ToDoList.Domain.Foos.Interfaces;

namespace ToDoList.Api.Controllers
{
    public class FooController : BaseController<Foo, FooDto>
    {
        private readonly ITransformer<Foo, FooDto> _transformer;

        public FooController(IBaseRepo<Foo> repo) : base(repo)
        {
            this._transformer = _transformer;
        }
        /*public FooController(IBuilder<Foo, FooDto> builder,ITransformer<Foo,FooDto> transformer) : base(builder)
        {
            this._transformer = transformer;
        }*/
        

       /* public FooController(IBaseRepo<Foo> repo, IBuilder<Foo,FooDto> builder) : base(repo,builder)
        {
        }*/
    }
}