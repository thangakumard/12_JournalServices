using System;
using System.Linq;
using Journal.DataAccess.Repositories.Context;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new JournalContext())
            {
                var users = context.Users.ToList();
                foreach (var user in users)
                {
                    Console.WriteLine(user.FirstName + " " + user.LastName);
                }
            }
            Console.ReadKey();
        }
    }
}
