using System;

namespace HomeLib.Entity.Interfaces.Storage
{
    public interface ISetting : IBaseEntity<Guid>
    {
        string Name { get; set; }
        string Value { get; set; }
    }
}