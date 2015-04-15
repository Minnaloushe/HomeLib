using System;

namespace HomeLib.Entity.Interfaces.Storage
{
    public interface IBook : IBaseEntity<Guid>
    {
        string Title { get; set; }
    }
}