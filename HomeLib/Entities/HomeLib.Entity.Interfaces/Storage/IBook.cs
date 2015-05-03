using System;

namespace HomeLib.Entity.Interfaces.Storage
{
    public interface IBook : IBaseEntity<Guid>
    {
        string Title { get; set; }
        int SerieIndex { get; set; }
        int FileIndex { get; set; }
        long ArchivedSize { get; set; }
        string FileName { get; set; }
        int Reserved8 { get; set; }
        string Format { get; set; }
        DateTime Date { get; set; }
        string Language { get; set; }
        int Reserved12 { get; set; }
        Guid ArchiveFileId { get; set; }
        Guid SerieId { get; set; }
    }
}