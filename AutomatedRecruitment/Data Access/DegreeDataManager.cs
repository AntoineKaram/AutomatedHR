using AutomatedRecruitment.Data;
using AutomatedRecruitment.Model;
using Data_Access.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data_Access.Data_Extension;
using System.Threading.Tasks;
namespace AutomatedRecruitment.DataAccess
{
   public class DegreeDataManager : DataManagerBase, IDegreeDataManager
    {
        public List<DegreeModel> GetDegree()
        {

            List<DegreeModel> degree = new List<DegreeModel>();
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("@LookupName", "Degree");
            dict.Add("@LCID", 1033);
            degree = ExecuteCollection<DegreeModel>("usp_Lookup_Get",
                (reader) =>
                {
                    DegreeModel degreeTemp = new DegreeModel()
                    {
                        attributeName = reader.GetValue<String>(0),
                        attributeValue = reader.GetValue<String>(1),
                        LCID = reader.GetValue<int>(2)
                    };
                    return degreeTemp;
                },dict);


            return degree;


        }
    }
    
}
