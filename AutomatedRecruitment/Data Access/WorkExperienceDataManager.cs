using AutomatedRecruitment.Data;
using Data_Access.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatedRecruitment.Model;

namespace AutomatedRecruitment.DataAccess
{
   public class WorkExperienceDataManager : DataManagerBase, IWorkExperienceDataManager
    {
        public string onSubmitW(WorkExperienceModel workExperience)
        {
            if (workExperience != null)
            {
                Dictionary<string, object> dict = new Dictionary<string, object>();
                dict.Add("@FirstName", (workExperience.Employer));
                dict.Add("@LastName", (workExperience.StartDate));
                dict.Add("@Email", workExperience.EndDate);
                dict.Add("@Nationality", workExperience.Role);
                dict.Add("@MessageType", (workExperience.Location));

                if (ExecuteCommand("USP-WorkExperience-Insert", dict))
                {
                    return ("Application Submited");
                }
                else
                {
                    return ("Failed");
                }


            }
            return ("Application missing");
        }
    }
}
