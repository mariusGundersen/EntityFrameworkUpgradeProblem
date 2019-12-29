using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace UpgradeEntityFramework
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var context = new DatabaseContext())
            {
                var user = await context.MemberUsers.FirstOrDefaultAsync();

                Console.WriteLine(user.EventSignups.Count);
            }
        }
    }
}
