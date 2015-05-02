using System;

namespace HomeLib.Entity.Interfaces.Storage
{
    public interface ICategory : IBaseEntity<Guid>
    {
        string SystemName { get; set; }
        string Name { get; set; }
    }
}