using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace Outlook2013AddIn
{
    public partial class Winpat
    {
        private void Winpat_Load(object sender, RibbonUIEventArgs e)
        {
            GetEnglishLabels();
            VerifyWinpatProperty();
        }

        private void btnAttachArtifact_Click(object sender, RibbonControlEventArgs e)
        {
            MessageBox.Show("Please Attach file!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void GetEnglishLabels()
        {
            //var resourceManager = Properties.Resources.ResourceManager;
            //var exampleString = resourceManager.GetString("btnAttachArtifactLabel");
            var language = new Language();
            int localeId = language.FindCurrentLanguage();
            var englishLabels = language.VerifyLocaleId(localeId);
            if (englishLabels != null)
            {
                if (englishLabels.ContainsKey("btnAttachArtifactLabel"))
                    btnAttachArtifact.Label = englishLabels["btnAttachArtifactLabel"];

                if (englishLabels.ContainsKey("btnAttachArtifactScreenTip"))
                    btnAttachArtifact.ScreenTip = englishLabels["btnAttachArtifactScreenTip"];
            }

        }

        public void VerifyWinpatProperty()
        {
            Outlook.MailItem mailItem = null;
            Outlook.UserProperty winpatProperty = null;

            mailItem = Globals.ThisAddIn.Application.ActiveInspector().CurrentItem as Outlook.MailItem;

            if (mailItem == null)
            {
                btnAttachArtifact.Enabled = false;
                return;
            }

            winpatProperty = mailItem.UserProperties.Find("WinpatProperty", Outlook.OlUserPropertyType.olText);
            if (winpatProperty == null)
            {
                btnAttachArtifact.Enabled = false;
                return;
            }

            if (winpatProperty.Value != "WINPAT")
                btnAttachArtifact.Enabled = false;
        }
    }
}

