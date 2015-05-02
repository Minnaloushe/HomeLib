using System;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Database.DTO
{
    public class ArchiveFile : IArchiveFile
    {
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public long Size { get; set; }
    }
}