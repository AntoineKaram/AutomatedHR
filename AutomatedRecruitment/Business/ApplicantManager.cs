using AutomatedRecruitment.Data;
using AutomatedRecruitment.DataAccess;
using AutomatedRecruitment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedRecruitment.Business
{
    public class ApplicantManager
    {
        public ApplicantDataManager _applicationDataManager;
        public ApplicantManager()
        {
            _applicationDataManager = new ApplicantDataManager();
        }
        public string onSubmit(ApplicantModel application)
        {
            return _applicationDataManager.onSubmit(application);
        }
    }
}
