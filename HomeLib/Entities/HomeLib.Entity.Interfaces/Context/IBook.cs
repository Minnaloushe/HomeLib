using System;
using System.Collections.Generic;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Interfaces.Context
{
    public interface IBook : IContextEntity<Guid>
    {
        string Title { get; set; }

        ICollection<IAuthor> Authors { get; }
    }
}
