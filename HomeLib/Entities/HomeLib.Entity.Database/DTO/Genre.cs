using System;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Database.DTO
{
    public class Genre : IGenre
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}