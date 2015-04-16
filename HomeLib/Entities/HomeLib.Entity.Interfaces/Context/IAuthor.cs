using System;
using System.Collections.Generic;

namespace HomeLib.Entity.Interfaces.Context
{
    public interface IAuthor : IContextEntity<Guid>
    {
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }

        ICollection<IBook> Books { get; }
    }
}