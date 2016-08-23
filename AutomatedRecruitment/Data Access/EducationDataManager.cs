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
   public class EducationDataManager : DataManagerBase, IEducationDataManager
    {
        public string onSubmitE(EducationModel education)
        {
            if (education != null)
            {
                Dictionary<string, object> dict = new Dictionary<string, object>();
                dict.Add("@Institute", (education.Institute ) );
                dict.Add("@GPA", (education.GPA )) ;
                dict.Add("@Diploma", education.Diploma);
  

                if (ExecuteCommand("USP-Education-Insert", dict))
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

