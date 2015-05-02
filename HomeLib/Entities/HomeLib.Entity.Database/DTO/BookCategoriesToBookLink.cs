using System;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Database.DTO
{
    public class BookCategoriesToBookLink : IBookCategoriesToBookLink
    {
        public Guid Id { get; set; }
        public Guid BookId { get; set; }
        public Guid CategoryId { get; set; }
    }
}