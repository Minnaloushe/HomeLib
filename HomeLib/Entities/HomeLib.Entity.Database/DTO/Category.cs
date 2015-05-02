using System;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Database.DTO
{
    public class Category : ICategory
    {
        public Guid Id { get; set; }
        public string SystemName { get; set; }
        public string Name { get; set; }
    }
}