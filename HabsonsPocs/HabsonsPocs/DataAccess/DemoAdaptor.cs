using CommonAppPoco.Model;
using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DemoAdaptor
    {
        public List<ApplicantType> GetApplicants()
        {
            List<ApplicantType> lstApplicant = new List<ApplicantType>();
            using (var context = new CACloud14Entities())
            {
                lstApplicant = (from app in context.ApplicantTypes
                                  select app).ToList<ApplicantType>();

            }
            return lstApplicant;
        }
    }
}
