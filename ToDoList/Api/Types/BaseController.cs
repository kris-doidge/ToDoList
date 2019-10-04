using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Core.Interfaces;
using ToDoList.Core.Types;

namespace ToDoList.Api.Types
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TEntityType,TDtoType> : ControllerBase where TEntityType : BaseRootEntity 
        where TDtoType : class
    {
        private readonly IBaseRepo<TEntityType> _repo;
        private readonly IBuilder<TEntityType, TDtoType> _builder;

        public BaseController(IBaseRepo<TEntityType> repo)
        {
            this._repo = repo;
        }

        public BaseController(IBuilder<TEntityType, TDtoType> builder)
        {
            this._builder = builder;
        }
        public BaseController(IBaseRepo<TEntityType> repo, IBuilder<TEntityType,TDtoType> builder)
        {
            this._repo = repo;
            this._builder = builder;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"value1", "value2"};
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}