using System;

namespace HomeLib.Entity.Interfaces.Storage
{
    public interface ISerie : IBaseEntity<Guid>
    {
        string Name { get; set; }
    }
}