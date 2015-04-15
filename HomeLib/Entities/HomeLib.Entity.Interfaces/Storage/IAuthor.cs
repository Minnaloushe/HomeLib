using System;

namespace HomeLib.Entity.Interfaces.Storage
{
    public interface IAuthor : IBaseEntity<Guid>
    {
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }
    }
}