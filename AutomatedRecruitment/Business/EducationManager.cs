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
   public class EducationManager
    {
        public IEducationDataManager _educationDataManager;
        public EducationManager()
        {
            _educationDataManager = new EducationDataManager();
        }
        public string onSubmitE(EducationModel education)
        {
            return _educationDataManager.onSubmitE(education);
        }
    }
}
