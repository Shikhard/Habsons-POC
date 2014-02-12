using DataAccess.Adaptor;
using Entities.Model;
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
                UserAdaptor userAdaptor = new UserAdaptor();
                List<userdata> lstUser = userAdaptor.GetUsers();
                foreach (var user in lstUser)
                {
                    Console.Write("First Name: {0}\t", user.FirstName);
                    Console.Write("Last Name: {0}\t", user.LastName);
                    Console.Write("City: {0}\t", user.userdetail != null ? user.userdetail.City : "");
                    Console.WriteLine("State: {0}\n", user.userdetail != null ? user.userdetail.State : "");
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
