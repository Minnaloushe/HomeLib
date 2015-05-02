using System;

namespace HomeLib.Entity.Interfaces.Storage
{
    public interface IArchiveFile : IBaseEntity<Guid>
    {
        string FileName { get; set; }
        long Size { get; set; }
    }
}