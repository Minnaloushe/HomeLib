using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using HomeLib.Entity.Database.DTO;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Database.IoC
{
    public class DbEntityModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Book>().As<IBook>();
            builder.RegisterType<Author>().As<IAuthor>();
            builder.RegisterType<Genre>().As<IGenre>();
            builder.RegisterType<ArchiveFile>().As<IArchiveFile>();
            builder.RegisterType<AuthorToBookLink>().As<IAuthorToBookLink>();
            builder.RegisterType<BookCategoriesToBookLink>().As<IBookCategoriesToBookLink>();
            builder.RegisterType<BookGenresToBookLink>().As<IBookGenresToBookLink>();
            builder.RegisterType<Category>().As<ICategory>();
            builder.RegisterType<Serie>().As<ISerie>();
            builder.RegisterType<Setting>().As<ISetting>();
        }
    }
}
