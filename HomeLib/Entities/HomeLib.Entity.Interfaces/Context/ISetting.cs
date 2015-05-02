using System;

namespace HomeLib.Entity.Interfaces.Context
{
    public interface ISetting : IContextEntity<Guid>
    {
        string Name { get; set; }
        string Value { get; set; }
    }
}