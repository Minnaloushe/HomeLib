using System;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Database.DTO
{
    public class Book : IBook
    {
        protected bool Equals(Book other)
        {
            return Id.Equals(other.Id) && string.Equals(Title, other.Title) && SerieIndex == other.SerieIndex &&
                   FileIndex == other.FileIndex && ArchivedSize == other.ArchivedSize &&
                   string.Equals(FileName, other.FileName) && Reserved8 == other.Reserved8 &&
                   string.Equals(Format, other.Format) && 
                   string.Equals(Language, other.Language) && Reserved12 == other.Reserved12 &&
                   ArchiveFileId.Equals(other.ArchiveFileId) && SerieId.Equals(other.SerieId);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Id.GetHashCode();
                hashCode = (hashCode*397) ^ (Title != null ? Title.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ SerieIndex;
                hashCode = (hashCode*397) ^ FileIndex;
                hashCode = (hashCode*397) ^ ArchivedSize.GetHashCode();
                hashCode = (hashCode*397) ^ (FileName != null ? FileName.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ Reserved8;
                hashCode = (hashCode*397) ^ (Format != null ? Format.GetHashCode() : 0);
//                hashCode = (hashCode*397) ^ Date.GetHashCode();
                hashCode = (hashCode*397) ^ (Language != null ? Language.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ Reserved12;
                hashCode = (hashCode*397) ^ ArchiveFileId.GetHashCode();
                hashCode = (hashCode*397) ^ SerieId.GetHashCode();
                return hashCode;
            }
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public int SerieIndex { get; set; }
        public int FileIndex { get; set; }
        public long ArchivedSize { get; set; }
        public string FileName { get; set; }
        public int Reserved8 { get; set; }
        public string Format { get; set; }
        public DateTime Date { get; set; }
        public string Language { get; set; }
        public int Reserved12 { get; set; }
        public Guid ArchiveFileId { get; set; }
        public Guid SerieId { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Book) obj);
        }
    }
}