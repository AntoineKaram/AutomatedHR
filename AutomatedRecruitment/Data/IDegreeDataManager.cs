using AutomatedRecruitment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedRecruitment.Data
{
    public interface IDegreeDataManager
    {
        List<DegreeModel> GetDegree();
    }
}
