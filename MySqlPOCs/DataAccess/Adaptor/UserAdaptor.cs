using DB;
using Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Adaptor
{
    public class UserAdaptor
    {
        public List<userdata> GetUsers()
        {
            try
            {
                List<userdata> lstUser = new List<userdata>();
                using (var context = new demoEntities())
                {

                    var users = (from u in context.userdatas
                                 select u).ToList();
                    userdata user;
                    foreach (var u in users)
                    {
                        user = new userdata()
                        {
                            FirstName = u.FirstName,
                            LastName = u.LastName,
                            userdetail = new userdetail()
                            {
                                City = u.userdetail != null ? u.userdetail.City : "",
                                State = u.userdetail != null ? u.userdetail.State : ""
                            }
                        };
                        lstUser.Add(user);
                    }
                    return users;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
