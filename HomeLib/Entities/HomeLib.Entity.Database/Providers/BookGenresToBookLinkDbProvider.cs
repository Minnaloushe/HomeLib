using System;
using System.Data;
using HomeLib.Entity.Database.DTO;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Database.Providers
{
    public interface IBookGenresToBookLinkDbProvider : IDbProvider<IBookGenresToBookLink, BookGenresToBookLink, Guid>
    {
        
    }
    public class BookGenresToBookLinkDbProvider : DbEntityProvider<IBookGenresToBookLink, BookGenresToBookLink, Guid>, IBookGenresToBookLinkDbProvider
    {
        public BookGenresToBookLinkDbProvider(IDbConnection connection) : base(connection)
        {
        }
    }
}