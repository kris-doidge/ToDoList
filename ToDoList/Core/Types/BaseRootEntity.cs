using System;
using ToDoList.Core.Interfaces;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ToDoList.Core.Types
{
    public abstract class BaseRootEntity : IBaseRootEntity
    {
        #region Properties

        public DateTime CreateDate { get; private set; }
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public Guid Id { get; private set; }

        #endregion

        #region Constructors

        protected BaseRootEntity(string str)
        {
            Id = Guid.NewGuid();
            CreateDate = DateTime.Now;
        }
        
        #endregion
    }
}