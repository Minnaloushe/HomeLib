using System;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Database.DTO
{
    public class AuthorToBookLink : IAuthorToBookLink
    {
        public Guid Id { get; set; }

        public Guid BookId { get; set; }

        public Guid AuthorId { get; set; }
    }
}