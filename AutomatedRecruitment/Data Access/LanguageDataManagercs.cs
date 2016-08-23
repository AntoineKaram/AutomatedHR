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
    public class LanguageDataManagercs : DataManagerBase, ILanguageDataManager
    {
        public string onSubmitL(LanguageModel language)
        {
            if (language != null)
            {
                Dictionary<string, object> dict = new Dictionary<string, object>();
                dict.Add("@Language", (language.Language));
                dict.Add("@DoP", (language.DoP));
                

                if (ExecuteCommand("USP-Language-Insert", dict))
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
