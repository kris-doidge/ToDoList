using System;

namespace ToDoList.Core.Interfaces
{
    public interface IBaseRootEntity
    {
        #region Properties

        DateTime CreateDate { get; }
        Guid Id { get; }

        #endregion

    }
}