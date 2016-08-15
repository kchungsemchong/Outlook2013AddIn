using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;

namespace Outlook2013AddIn
{
    public class Language
    {
        public int FindCurrentLanguage()
        {
            var currentCulture = Thread.CurrentThread.CurrentCulture;
            int localeId = currentCulture.LCID;

            return localeId;
        }

        public Dictionary<string, string> GetEnglishLabels()
        {
            //I tried to add the labels into the Resource but it didn't work
            //using (ResXResourceWriter resx = new ResXResourceWriter(@".\Ribbon1.resx"))
            //{
            //    resx.AddResource("btnAttachArtifactLabel", "Attach item");
            //    resx.AddResource("btnAttachArtifactScreenTip", "Attach artifacts from WiNPAT");
            //}

            var englishLabels = new Dictionary<string, string>()
            {
                {"btnAttachArtifactLabel", "Attach item"},
                {"btnAttachArtifactScreenTip", "Attach artifacts from WiNPAT"}
            };

            return englishLabels;
        }

        public Dictionary<string, string> VerifyLocaleId(int localeId)
        {
            Dictionary<string, string> englishLabels = null;
            var localeIds = new List<int>()
            {
                1033,
                2057
            };
            bool isInList = localeIds.IndexOf(localeId) != -1;
            if (isInList == true)
            {
                if (!(localeId <= 0))
                {
                    englishLabels = GetEnglishLabels();
                }
            }


            return englishLabels;
        }


    }
}
