using System;

namespace ToDoList.Application.Foos
{
    public class FooDto
    {
        #region Properties

        public string Foos { get; set; }
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }

        #endregion
    }
}