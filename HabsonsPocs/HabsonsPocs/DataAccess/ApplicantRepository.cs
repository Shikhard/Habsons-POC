using CommonAppPoco.Model;
using RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ApplicantRepository : Repository<ApplicantType>, IApplicant
    {
        public ApplicantType GetApplicantTypeById(int ApplicantTypeId)
        {
            return DbSet.Where(x => x.ApplicantTypeId == ApplicantTypeId).FirstOrDefault();
        }
    }
}
