using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace MetaDisk.Tests
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void TestMethod1()
        //{
        //}

        [TestMethod]
        public async Task TestMethod1()
        {
            MetaDisk.UserClient users = new MetaDisk.UserClient();
            Storj.net.Models.NewUserRequest user = new Storj.net.Models.NewUserRequest()
            {
                Email = "lucas2@bitcoinbrisbane.com.au",
                Password = "f8703825da792b62bdda35abee1a3d51cbdd69963a8f2277eef86fc078be2d91"
            };

            //await users.AddAsync(user);
        }
    }
}
