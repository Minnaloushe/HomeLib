using System;

namespace HomeLib.Entity.Interfaces.Context
{
    public interface IGenre : IContextEntity<Guid>
    {
        string Name { get; set; }

        IManyToManyLinkedProperty<IBook> Books { get; }
    }
}