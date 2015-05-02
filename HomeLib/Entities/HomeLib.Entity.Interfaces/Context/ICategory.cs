using System;

namespace HomeLib.Entity.Interfaces.Context
{
    public interface ICategory : IContextEntity<Guid>
    {
        string SystemName { get; set; }
        string Name { get; set; }
        IManyToManyLinkedProperty<IBook> Books { get; } 
    }
}