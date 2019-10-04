using System;
using System.Security.Cryptography.X509Certificates;
using MongoDB.Bson.Serialization.Attributes;
using ToDoList.Core.Types;

namespace ToDoList.Domain.Foos
{
    public class Foo : BaseRootEntity
    {
        #region Properties
        [BsonElement("Foo")]
        public string Foos { get; private set; }

        #endregion

        #region Constructors
        
        public Foo(string foo) : base(foo)
        {
            Foos = foo;
        }
        
        #endregion
        
    }
}