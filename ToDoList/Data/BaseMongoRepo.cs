using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;
using ToDoList.Core.Interfaces;
using ToDoList.Core.Types;
using ToDoList.Databases;

namespace ToDoList.Data
{
    public class BaseMongoRepo<TEntityType> : IBaseRepo<TEntityType> where TEntityType : BaseRootEntity
    {
        private readonly IMongoCollection<TEntityType> _entities;

        #region Constructor

        public BaseMongoRepo(IFooDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _entities = database.GetCollection<TEntityType>(settings.FooCollectionName);
        }

        #endregion
        public Task Delete(TEntityType entity)
        {
            return _entities.DeleteOneAsync(ent => ent.Id == entity.Id);
        }

        public Task DeleteById(Guid id)
        {
            return _entities.DeleteOneAsync(ent => ent.Id == id);
        }

        public Task Create(TEntityType entity)
        {
            return _entities.InsertOneAsync(entity);
        }

        public Task<List<TEntityType>> Find(TEntityType type)
        {
            throw new NotImplementedException();
        }
    }
}