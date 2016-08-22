using AutomatedRecruitment.Data;
using AutomatedRecruitment.DataAccess;
using AutomatedRecruitment.Model;
using Data_Access.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutomatedRecruitment.Business
{
   public class DegreeManager
    {
        public DegreeDataManager _degreeDataManager;
        public DegreeManager()
        {
            _degreeDataManager = new DegreeDataManager();
        }
        public List<DegreeModel> GetDegree()
        {
            return _degreeDataManager.GetDegree();
        }
    }
}


