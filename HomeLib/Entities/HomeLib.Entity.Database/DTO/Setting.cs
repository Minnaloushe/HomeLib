using System;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Database.DTO
{
    public class Setting : ISetting
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}