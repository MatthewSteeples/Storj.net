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
            MetaDisk.Users users = new MetaDisk.Users();
            Storj.net.Models.User user = new Storj.net.Models.User()
            {
                Email = "lucas@bitcoinbrisbane.com.au",
                Created = DateTime.UtcNow
            };

            await users.AddAsync(user);
        }
    }
}
