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
   public class WorkExperienceManager
    {
        public IWorkExperienceDataManager _workDataManager;
        public WorkExperienceManager()
        {
            _workDataManager = new WorkExperienceDataManager();
        }
        public string onSubmitW(WorkExperienceModel work)
        {
            return _workDataManager.onSubmitW(work);
        }
    }
}
