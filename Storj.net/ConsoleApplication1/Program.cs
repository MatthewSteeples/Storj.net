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
            MetaDisk.Users users = new MetaDisk.Users();
            Storj.net.Models.User user = new Storj.net.Models.User()
            {
                Email = "lucas@bitcoinbrisbane.com.au",
                Created = DateTime.UtcNow
            };

            users.AddAsync(user);
        }
    }
}
