using MySqlDataFirstConsole.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlDataFirstConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var context = new demoEntities())
                {
                    var user = (from u in context.userdatas
                               select u).ToList();
                    foreach (var u in user)
                    {
                        Console.Write("First Name: {0}\t", u.FirstName);
                        Console.WriteLine(u.userdetail != null ? u.userdetail.City : "");
                    }
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
