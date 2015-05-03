using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using Autofac;
using HomeLib.Entity.Database;
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
            using (var provider = Container.Resolve<IAuthorDbProvider>())
            {
                #region Arrange 

                var expectedAuthor = Container.Resolve<IAuthor>();

                expectedAuthor.Id = Guid.NewGuid();
                expectedAuthor.FirstName = ValueHelper.GetAnonymousString();
                expectedAuthor.MiddleName = ValueHelper.GetAnonymousString();
                expectedAuthor.LastName = ValueHelper.GetAnonymousString();

                provider.Insert(expectedAuthor);

                #endregion

                #region Act

                var actualAuthor = provider.GetById(expectedAuthor.Id);

                #endregion

                #region Assert

                Assert.AreEqual(expectedAuthor.Id, actualAuthor.Id);
                Assert.AreEqual(expectedAuthor.FirstName, actualAuthor.FirstName);
                Assert.AreEqual(expectedAuthor.MiddleName, actualAuthor.MiddleName);
                Assert.AreEqual(expectedAuthor.LastName, actualAuthor.LastName);

                #endregion
            }
        }

        [TestMethod]
        public void UpdateAuthorTest()
        {
            using (var provider = Container.Resolve<IAuthorDbProvider>())
            {
                #region Arrange


                var expectedAuthor = Container.Resolve<IAuthor>();

                expectedAuthor.Id = Guid.NewGuid();
                expectedAuthor.FirstName = ValueHelper.GetAnonymousString();
                expectedAuthor.MiddleName = ValueHelper.GetAnonymousString();
                expectedAuthor.LastName = ValueHelper.GetAnonymousString();

                provider.Insert(expectedAuthor);

                expectedAuthor.FirstName = ValueHelper.GetAnonymousString();
                expectedAuthor.MiddleName = ValueHelper.GetAnonymousString();
                expectedAuthor.LastName = ValueHelper.GetAnonymousString();

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
        }

        [TestMethod]
        [ExpectedException(typeof(DbEntityProvider<IAuthor, Author, Guid>.EntityNotFoundException))]
        public void GetByIdFailTest()
        {
            using (var provider = Container.Resolve<IAuthorDbProvider>())
            {

                #region Arrange

                #endregion

                #region Act

                provider.GetById(Guid.NewGuid());

                #endregion
            }
        }

        [TestMethod]
        [ExpectedException(typeof(DbEntityProvider<IAuthor, Author, Guid>.EntityNotFoundException))]
        public void UpdateFailTest()
        {
            using (var provider = Container.Resolve<IAuthorDbProvider>())
            {
                #region Arrange

                var entity = Container.Resolve<IAuthor>();
                entity.Id = Guid.NewGuid();

                #endregion

                #region Act

                provider.Update(entity);

                #endregion
            }
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void InsertFailTest()
        {
            using (var provider = Container.Resolve<IAuthorDbProvider>())
            {
                #region Arrange

                var entity = Container.Resolve<IAuthor>();
                entity.Id = Guid.NewGuid();
                entity.FirstName = ValueHelper.GetAnonymousString();
                entity.MiddleName = ValueHelper.GetAnonymousString();
                entity.LastName = ValueHelper.GetAnonymousString();

                provider.Insert(entity);

                #endregion

                #region Act

                provider.Insert(entity);

                #endregion
            }
        }

        [TestMethod]
        [ExpectedException(typeof(DbEntityProvider<IAuthor, Author, Guid>.EntityNotFoundException))]
        public void DeleteFailTest()
        {
            using (var provider = Container.Resolve<IAuthorDbProvider>())
            {

                #region Act

                provider.Delete(Guid.NewGuid());

                #endregion
            }
        }

        [TestCleanup]
        public void TestCleanup()
        {
            using (var provider = Container.Resolve<IAuthorDbProvider>())
            {
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
}
