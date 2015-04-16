using System;
using System.Collections.Generic;

namespace HomeLib.Entity.Interfaces.Context
{
    public interface IBook : IContextEntity<Guid>
    {
        string Title { get; set; }

        ICollection<IAuthor> Authors { get; }
    }
}
