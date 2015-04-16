using System;
using Autofac;
using HomeLib.Entity.Database.Providers;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Database.IoC
{
    class DbProviderModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BookDbProvider>().As<IDbProvider<IBook,Guid>>();
            builder.RegisterType<AuthorDbProvider>().As<IDbProvider<IAuthor, Guid>>();
        }
    }
}