using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatedRecruitment.Model;
namespace AutomatedRecruitment.Data
{
   public interface IApplicantDataManager
    {
        string onSubmitA(ApplicantModel application);
    }
}
