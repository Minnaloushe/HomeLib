using System;

namespace HomeLib.Entity.Interfaces.Storage
{
    public interface IGenre : IBaseEntity<Guid>
    {
        string Name { get; set; }
    }
}