using System;

namespace HomeLib.Entity.Interfaces.Storage
{
    public interface IBookCategoriesToBookLink : IBaseEntity<Guid>
    {
        Guid BookId { get; set; }
        Guid CategoryId { get; set; }
    }
}