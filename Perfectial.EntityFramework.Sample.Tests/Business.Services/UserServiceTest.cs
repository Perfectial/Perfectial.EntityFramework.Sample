using LegalDecoder.Tests.Common.DatabaseInitializers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Perfectial.Tests.Common;
using System.Linq;
using System.Threading.Tasks;
using Perfectial.EntityFramework.Sample.DataAccess;
using Perfectial.EntityFramework.Sample.Business;
using Perfectial.EntityFramework.Sample.Common.DTOs;
using Perfectial.EntityFramework.Sample.DataAccess.Models.Enums;
using Perfectial.EntityFramework.Sample.DataAccess.Models;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;

namespace LegalDecoder.Tests.Business.Services
{
    [TestClass]
    public class UserServiceTest
    {
        private const string ConnectionStringName = "UserServiceTestContext";
        private static DataContext dataContext;
        private static StudentService _service;

        [ClassInitialize]
        public static void InitTestClass(TestContext context)
        {
            dataContext = TestDatabaseCreator.Create<UserDataInitializer>(ConnectionStringName);
            _service = new StudentService(dataContext);
        }

        [ClassCleanup]
        public static void CleanupTestClass()
        {
            dataContext.Dispose();
        }

        [TestMethod]
        public void SaveUsersAsync_Test()
        {
            StudentSpecification first = new StudentSpecification()
            {
                Name = "John@mail.com",
                Password = "123456",
                Type =  StudentType.Custom
            };
            var resultClient = _service.UpdateUserAsync(first).Result;

            StudentSpecification second = new StudentSpecification()
            {
                Name = "George@mail.com",
                Password = "123456",
                Type = StudentType.Simple
            };
            var resultModerator = _service.UpdateUserAsync(second).Result;

            Assert.IsTrue(resultClient);
            Assert.IsTrue(resultModerator);
        }

        [TestMethod]
        public void DeleteUserAsync_Test()
        {
            var user = dataContext.Set<Student>().FirstOrDefault();
            var userId = user.Id;

            _service.DeleteAsync(userId).GetAwaiter().GetResult();

            ((IObjectContextAdapter)dataContext).ObjectContext.Refresh(RefreshMode.StoreWins, user);

            Assert.IsTrue(user.Deleted);
        }
    }
}
