using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace HomeLib.Entity.Interfaces.Context
{
    public interface IBook : IContextEntity<Guid>
    {
        string Title { get; set; }

        int SerieIndex { get; set; }
        int FileIndex { get; set; }
        long ArchivedSize { get; set; }
        string FileName { get; set; }
        int Reserve8 { get; set; }
        string Format { get; set; }
        DateTime Date { get; set; }
        string Language { get; set; }
        int Reserve12 { get; set; }
        IArchiveFile ArchiveFileId { get; set; }
        ISerie SerieId { get; set; }
        IManyToManyLinkedProperty<IAuthor> Authors { get; }
        IManyToManyLinkedProperty<ICategory> Categories { get; }
        IManyToManyLinkedProperty<IGenre> Genres { get; }
    }
}
