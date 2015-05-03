using System;
using HomeLib.Entity.Interfaces.Storage;

namespace TestHelpers
{
    public static class EntityHelper
    {
        public static void InitializeAnonymousBook(IBook book, ISerie serie, IArchiveFile archiveFile)
        {
            book.Id = Guid.NewGuid();
            book.ArchiveFileId = archiveFile.Id;
            book.ArchivedSize = ValueHelper.GetAnonymousInt();
            book.Date = ValueHelper.GetAnonymousDate();
            book.FileIndex = ValueHelper.GetAnonymousInt();
            book.FileName = ValueHelper.GetAnonymousString();
            book.Format = ValueHelper.GetAnonymousString();
            book.Language = ValueHelper.GetAnonymousString();
            book.Reserved12 = ValueHelper.GetAnonymousInt();
            book.Reserved8 = ValueHelper.GetAnonymousInt();
            book.SerieId = serie.Id;
            book.SerieIndex = ValueHelper.GetAnonymousInt();
            book.Title = ValueHelper.GetAnonymousString();
        }

        public static void InitializeAnonymousArchiveFile(IArchiveFile archiveFile)
        {
            archiveFile.Id = Guid.NewGuid();
            archiveFile.FileName = ValueHelper.GetAnonymousString();
            archiveFile.Size = ValueHelper.GetAnonymousInt();
        }

        public static void InitializeAnonymousSerie(ISerie serie)
        {
            serie.Id = Guid.NewGuid();
            serie.Name = ValueHelper.GetAnonymousString();
        }
    }
}