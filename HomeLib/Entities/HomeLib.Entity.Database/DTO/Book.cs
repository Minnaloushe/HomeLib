using System;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Database.DTO
{
    public class Book : IBook
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
    }
}