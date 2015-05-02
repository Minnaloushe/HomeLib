using System;

namespace HomeLib.Entity.Interfaces.Storage
{
    public interface IAuthorToBookLink : IBaseEntity<Guid>
    {
        Guid BookId { get; set; }
        Guid AuthorId { get; set; }
    }
}