using System;

namespace HomeLib.Entity.Interfaces.Context
{
    public interface ISerie : IContextEntity<Guid>
    {
        Guid Name { get; set; }
    }
}