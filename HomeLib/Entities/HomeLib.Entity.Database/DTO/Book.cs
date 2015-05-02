using System;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Database.DTO
{
    public class Book : IBook
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int SerieIndex { get; set; }
        public int FileIndex { get; set; }
        public long ArchivedSize { get; set; }
        public string FileName { get; set; }
        public int Reserve8 { get; set; }
        public string Format { get; set; }
        public DateTime Date { get; set; }
        public string Language { get; set; }
        public int Reserve12 { get; set; }
        public Guid ArchiveFileId { get; set; }
        public Guid SerieId { get; set; }
    }
}