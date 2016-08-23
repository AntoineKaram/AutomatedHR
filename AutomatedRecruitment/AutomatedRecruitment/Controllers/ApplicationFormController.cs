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
        private ApplicantManager _applicationManager;
        private EducationManager _educationManager;
        private WorkExperienceManager _workExperienceManager;
        private LanguageManager _languageManager;

        public ApplicationFormController()
        {
            _degreeManager = new DegreeManager();
            _applicationManager = new ApplicantManager();
            _educationManager = new EducationManager();
            _workExperienceManager = new WorkExperienceManager();
            _languageManager = new LanguageManager();
        }

        [HttpGet]

        public List<DegreeModel> GetDegree()
        {
            return _degreeManager.GetDegree();
        }

        public string onSubmit(ApplicantModel application)
        {
            return _applicationManager.onSubmitA(application);
        }
        public string onSubmitE (EducationModel education)
        {
            return _educationManager.onSubmitE(education);
        }
        public string onSubmitW(WorkExperienceModel work)
        {
            return _workExperienceManager.onSubmitW(work);
        }
        public string onSubmitL(LanguageModel language)
        {
            return _languageManager.onSubmitL(language);
        }
    }
}
