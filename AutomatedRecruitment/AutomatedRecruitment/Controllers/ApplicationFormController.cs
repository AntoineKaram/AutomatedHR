using AutomatedRecruitment.Business;
using AutomatedRecruitment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AutomatedRecruitment.Controllers
{
    public class ApplicationFormController : ApiController
    {
        private DegreeManager _degreeManager;

        public ApplicationFormController()
        {
            _degreeManager = new DegreeManager();
        }

        [HttpGet]

        public List<DegreeModel> GetDegree()
        {
            return _degreeManager.GetDegree();
        }
    }
}
