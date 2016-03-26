using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            MetaDisk.UserClient client = new MetaDisk.UserClient();
            Storj.net.Models.NewUserRequest user = new Storj.net.Models.NewUserRequest()
            {
                Email = "lucas3@bitcoinbrisbane.com.au",
                Password = "f8703825da792b62bdda35abee1a3d51cbdd69963a8f2277eef86fc078be2d91"
            };

            var response = client.AddAsync(user).Result;
        }
    }
}
