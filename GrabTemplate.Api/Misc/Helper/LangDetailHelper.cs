using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrabTemplate.Models;

namespace GrabTemplate.Misc.Helper
{
    public static class LangDetailHelper
    {
        public static IList<LangDetailViewModel> LangDetails { get; set; }

        public static string Get(int langId, string name)
        {
            return LangDetails.FirstOrDefault(x => x.LangId == langId && x.Name == name).Value;
        }
    }
}
