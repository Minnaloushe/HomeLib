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
    class DbEntityModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Book>().As<IBook>();
            builder.RegisterType<Author>().As<IAuthor>();

        }
    }
}
