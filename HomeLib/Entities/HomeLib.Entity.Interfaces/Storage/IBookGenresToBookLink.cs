using System;

namespace HomeLib.Entity.Interfaces.Storage
{
    public interface IBookGenresToBookLink : IBaseEntity<Guid>
    {
        Guid BookId { get; set; }
        Guid GenreId { get; set; }
    }
}