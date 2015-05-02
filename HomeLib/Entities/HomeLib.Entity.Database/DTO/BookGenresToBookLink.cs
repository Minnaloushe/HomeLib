using System;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Database.DTO
{
    public class BookGenresToBookLink : IBookGenresToBookLink
    {
        public Guid Id { get; set; }
        public Guid BookId { get; set; }
        public Guid GenreId { get; set; }
    }
}