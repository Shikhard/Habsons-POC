using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Habsons.Web.Controllers
{
    public class ApplicantController : Controller
    {
        //
        // GET: /Applicant/
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult JsonData()
        {
            ApplicantTypeJson obj = new ApplicantTypeJson() { id = 1, name = "A" };
            var json = new JavaScriptSerializer().Serialize(obj);
            JsonResult jResult=new JsonResult();
            jResult.Data=json;
            return jResult;
        }
	}

    public class ApplicantTypeJson
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}