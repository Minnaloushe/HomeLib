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
    public class BookEntityTest
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

        private IBook InitializeBook()
        {
            var book = Container.Resolve<IBook>();

            using (var provider = Container.Resolve<IBookDbProvider>())
            using (var serieProvider = Container.Resolve<ISerieDbProvider>())
            using (var archiveProvider = Container.Resolve<IArchiveFileDbProvider>())
            {
                var serie = Container.Resolve<ISerie>();
                var archiveFile = Container.Resolve<IArchiveFile>();

                EntityHelper.InitializeAnonymousArchiveFile(archiveFile);
                EntityHelper.InitializeAnonymousSerie(serie);

                EntityHelper.InitializeAnonymousBook(book, serie, archiveFile);

                archiveProvider.Insert(archiveFile);
                serieProvider.Insert(serie);

                provider.Insert(book);
            }

            return book;
        }

        [TestMethod]
        public void GetBookByIdTest()
        {
            using (var provider = Container.Resolve<IBookDbProvider>())
            {
                #region Arrange

                var expectedBook = InitializeBook();
                
                #endregion

                #region Act

                var actualBook = provider.GetById(expectedBook.Id);

                #endregion

                #region Assert

                Assert.IsTrue(expectedBook.Equals(actualBook));
                //Assert.AreEqual(expectedBook, actualBook);

                #endregion
            }
        }

        [TestMethod]
        public void UpdateBookTest()
        {
            using (var provider = Container.Resolve<IBookDbProvider>())
            {
                #region Arrange


                var expectedBook = InitializeBook();

                var bookId = expectedBook.Id;

                expectedBook = InitializeBook();

                expectedBook.Id = bookId;

                #endregion

                #region Act

                provider.Update(expectedBook);

                #endregion

                #region Assert

                var actualBook = provider.GetById(expectedBook.Id);

                Assert.IsTrue(expectedBook.Equals(actualBook));

                #endregion
            }
        }

        [TestMethod]
        [ExpectedException(typeof(DbEntityProvider<IBook, Book, Guid>.EntityNotFoundException))]
        public void GetByIdFailTest()
        {
            using (var provider = Container.Resolve<IBookDbProvider>())
            {

                #region Arrange

                #endregion

                #region Act

                provider.GetById(Guid.NewGuid());

                #endregion
            }
        }

        [TestMethod]
        [ExpectedException(typeof(DbEntityProvider<IBook, Book, Guid>.EntityNotFoundException))]
        public void UpdateFailTest()
        {
            using (var provider = Container.Resolve<IBookDbProvider>())
            {
                #region Arrange

                var entity = InitializeBook();

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
            using (var provider = Container.Resolve<IBookDbProvider>())
            {
                #region Arrange

                var entity = InitializeBook();

                provider.Insert(entity);

                #endregion

                #region Act

                provider.Insert(entity);

                #endregion
            }
        }

        [TestMethod]
        [ExpectedException(typeof(DbEntityProvider<IBook, Book, Guid>.EntityNotFoundException))]
        public void DeleteFailTest()
        {
            using (var provider = Container.Resolve<IBookDbProvider>())
            {

                #region Act

                provider.Delete(Guid.NewGuid());

                #endregion
            }
        }

        [TestCleanup]
        public void TestCleanup()
        {
            using (var provider = Container.Resolve<IBookDbProvider>())
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

            using (var provider = Container.Resolve<IArchiveFileDbProvider>())
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
            using (var provider = Container.Resolve<ISerieDbProvider>())
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
