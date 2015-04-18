using System;

namespace HomeLib.Entity.Interfaces.Storage
{
    public interface IBookToAuthorLink : IBaseEntity<Guid>
    {
        Guid BookId { get; set; }
        Guid AuthorId { get; set; }
    }
}