using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using Autofac;
using HomeLib.Entity.Database.DTO;
using HomeLib.Entity.Database.IoC;
using HomeLib.Entity.Database.Providers;
using HomeLib.Entity.Interfaces.Storage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestHelpers;

namespace DbEntitesTest
{
    [TestClass]
    public class AuthorEntityTest
    {

        public IContainer Container;

        [TestInitialize]
        public void TestInitialize()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<DbEntityModule>();
            builder.RegisterModule<DbProviderModule>();
            builder.Register(d => new SqlConnection(ConfigurationManager.ConnectionStrings["DbEntitesTest.Properties.Settings.DBConnection"].ConnectionString)).As<IDbConnection>();
            Container = builder.Build();
        }

        [TestMethod]
        public void GetAuthorByIdTest()
        {
            #region Arrange 

            var expectedAuthor = Container.Resolve<IAuthor>();

            expectedAuthor.Id = Guid.NewGuid();
            expectedAuthor.FirstName = StringHelper.GetAnonymousString();
            expectedAuthor.MiddleName = StringHelper.GetAnonymousString();
            expectedAuthor.LastName = StringHelper.GetAnonymousString();

            Container.Resolve<IAuthorDbProvider>().Insert(expectedAuthor);

            #endregion

            #region Act

            var actualAuthor = Container.Resolve<IAuthorDbProvider>().GetById(expectedAuthor.Id);

            #endregion

            #region Assert

            Assert.AreEqual(expectedAuthor.Id, actualAuthor.Id);
            Assert.AreEqual(expectedAuthor.FirstName, actualAuthor.FirstName);
            Assert.AreEqual(expectedAuthor.MiddleName, actualAuthor.MiddleName);
            Assert.AreEqual(expectedAuthor.LastName, actualAuthor.LastName);

            #endregion
        }

        [TestMethod]
        public void UpdateAuthorTest()
        {
            #region Arrange

            var provider = Container.Resolve<IAuthorDbProvider>();
            var expectedAuthor = Container.Resolve<IAuthor>();

            expectedAuthor.Id = Guid.NewGuid();
            expectedAuthor.FirstName = StringHelper.GetAnonymousString();
            expectedAuthor.MiddleName = StringHelper.GetAnonymousString();
            expectedAuthor.LastName = StringHelper.GetAnonymousString();

            provider.Insert(expectedAuthor);

            expectedAuthor.FirstName = StringHelper.GetAnonymousString();
            expectedAuthor.MiddleName = StringHelper.GetAnonymousString();
            expectedAuthor.LastName = StringHelper.GetAnonymousString();

            #endregion

            #region Act

            provider.Update(expectedAuthor);

            #endregion

            #region Assert

            var actualAuthor = provider.GetById(expectedAuthor.Id);

            Assert.AreEqual(expectedAuthor.Id, actualAuthor.Id);
            Assert.AreEqual(expectedAuthor.FirstName, actualAuthor.FirstName);
            Assert.AreEqual(expectedAuthor.MiddleName, actualAuthor.MiddleName);
            Assert.AreEqual(expectedAuthor.LastName, actualAuthor.LastName);

            #endregion
        }

        [TestCleanup]
        public void TestCleanup()
        {
            var provider = Container.Resolve<IAuthorDbProvider>();

            while (true)
            {
                var entities = provider.GetPage(50);

                if (!entities.Any())
                {
                    break;
                }

                foreach (var entity in entities)
                {
                    provider.Delete(entity.Id);
                }
            }
        }
    }
}
