using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MetaDisk.Tests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public async void TestMethod1()
        {
            MetaDisk.UserClient users = new MetaDisk.UserClient();
            Storj.net.Models.NewUserRequest user = new Storj.net.Models.NewUserRequest()
            {
                Email = "lucas2@bitcoinbrisbane.com.au",
                Password = "f8703825da792b62bdda35abee1a3d51cbdd69963a8f2277eef86fc078be2d91"
            };

            await users.AddAsync(user);
        }
    }
}
