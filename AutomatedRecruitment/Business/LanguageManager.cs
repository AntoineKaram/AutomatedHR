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
    public class LanguageManager
    {
        public ILanguageDataManager _languageDataManager;
        public LanguageManager()
        {
            _languageDataManager = new LanguageDataManagercs();
        }
        public string onSubmitL(LanguageModel language)
        {
            return _languageDataManager.onSubmitL(language);
        }
    }
}
