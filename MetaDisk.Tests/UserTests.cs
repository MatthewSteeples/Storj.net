using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace MetaDisk.Tests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public async Task Should_Register_New_User()
        {
            Guid id = new Guid();
            id = Guid.NewGuid();

            MetaDisk.UserClient users = new MetaDisk.UserClient();
            Storj.net.Models.NewUserRequest user = new Storj.net.Models.NewUserRequest()
            {
                Email = String.Format("{0}@bitcoinbrisbane.com.au", id),
                Password = "f8703825da792b62bdda35abee1a3d51cbdd69963a8f2277eef86fc078be2d91"
            };

            var result = await users.AddAsync(user);
            Assert.IsNotNull(result);
        }
    }
}
