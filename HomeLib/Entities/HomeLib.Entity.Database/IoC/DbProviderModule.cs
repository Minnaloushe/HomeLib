using System;
using Autofac;
using HomeLib.Entity.Database.DTO;
using HomeLib.Entity.Database.Providers;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Database.IoC
{
    public class DbProviderModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BookDbProvider>().As<IBookDbProvider>();
            builder.RegisterType<AuthorDbProvider>().As<IAuthorDbProvider>();
            builder.RegisterType<ArchiveFileDbProvider>().As<IArchiveFileDbProvider>();
            builder.RegisterType<AuthorToBookLinkDbProvider>().As<IAuthorToBookLinkDbProvider>();
            builder.RegisterType<BookCategoriesToBookLinkDbProvider>().As<IBookCategoriesToBookLinkDbProvider>();
            builder.RegisterType<BookGenresToBookLinkDbProvider>().As<IBookGenresToBookLinkDbProvider>();
            builder.RegisterType<CategoryDbProvider>().As<ICategoryDbProvider>();
            builder.RegisterType<GenreDbProvider>().As<IGenreDbProvider>();
            builder.RegisterType<SerieDbProvider>().As<ISerieDbProvider>();
            builder.RegisterType<SettingDbProvider>().As<ISettingDbProvider>();
        }
    }
}