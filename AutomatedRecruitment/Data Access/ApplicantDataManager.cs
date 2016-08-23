using AutomatedRecruitment.Data;
using AutomatedRecruitment.Model;
using Data_Access.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedRecruitment.DataAccess
{
   public class ApplicantDataManager : DataManagerBase, IApplicantDataManager
    {
    

        public string onSubmitA(ApplicantModel application)
        {
            if (application != null)
            {
                Dictionary<string, object> dict = new Dictionary<string, object>();
                dict.Add("@FirstName", (application.FirstName != null) ? application.FirstName : "");
                dict.Add("@LastName", (application.LastName != null) ? application.LastName : "");
                dict.Add("@Email", application.Email);
                dict.Add("@Nationality", application.Nationality);
                dict.Add("@MessageType", (application.DateOfBirth != null) ? application.DateOfBirth : "");
                dict.Add("@MessageText", application.MobileNumber);

                if (ExecuteCommand("USP-Applicant-Insert", dict))
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


