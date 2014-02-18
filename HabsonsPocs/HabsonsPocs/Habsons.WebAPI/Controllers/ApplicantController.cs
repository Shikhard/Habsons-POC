using CommonAppPoco.Model;
using DataAccess;
using Habsons.WebAPI.AutoMapper;
using Habsons.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Habsons.WebAPI.Controllers
{
    public class ApplicantController : ApiController
    {
        [HttpGet]
        public IEnumerable<ApplicantTypeDTO> ApplicantTypes()
        {
            ApplicantRepository applicantRep = new ApplicantRepository();
            IQueryable<ApplicantType> lstApplicantType = applicantRep.All();
            List<ApplicantTypeDTO> lstApplicantTypeDTO = new List<ApplicantTypeDTO>();
            foreach (var applicantType in lstApplicantType)
            {
                lstApplicantTypeDTO.Add(
                    new ApplicantTypeDTO()
                    {
                        ApplicantTypeId = applicantType.ApplicantTypeId,
                        Name = applicantType.Name
                    });
            }
            return lstApplicantTypeDTO;
        }

        public IHttpActionResult GetProduct(int id)
        {
            ApplicantRepository applicantRep = new ApplicantRepository();
            ApplicantType appType = applicantRep.GetApplicantTypeById(id);

            if (appType == null)
            {
                return NotFound();
            }
            ApplicantTypeDTO appTypeDTO = new ApplicantTypeDTO()
            {
                ApplicantTypeId = appType.ApplicantTypeId,
                Name = appType.Name
            };


            //ViewAutoMapper<ApplicantTypeDTO>.ConvertDynamiceToViewObject(appTypeDTO, appType);

            return Ok(appTypeDTO);
        }
    }

}
