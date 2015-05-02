using System;

namespace HomeLib.Entity.Interfaces.Context
{
    public interface IArchiveFile : IContextEntity<Guid>
    {
        string FileName { get; set; }
        long Size { get; set; }
        IManyToManyLinkedProperty<IBook> Books { get; } 
    }
}