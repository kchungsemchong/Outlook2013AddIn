namespace Outlook2013AddIn
{
    partial class Winpat : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Winpat()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Winpat));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.grpWinpat = this.Factory.CreateRibbonGroup();
            this.btnAttachArtifact = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.grpWinpat.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.ControlId.OfficeId = "TabNewMailMessage";
            this.tab1.Groups.Add(this.grpWinpat);
            this.tab1.Label = "TabNewMailMessage";
            this.tab1.Name = "tab1";
            // 
            // grpWinpat
            // 
            this.grpWinpat.Items.Add(this.btnAttachArtifact);
            this.grpWinpat.Label = "WiNPAT";
            this.grpWinpat.Name = "grpWinpat";
            this.grpWinpat.Position = this.Factory.RibbonPosition.BeforeOfficeId("GroupIncludeMainTab");
            // 
            // btnAttachArtifact
            // 
            this.btnAttachArtifact.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnAttachArtifact.Image = ((System.Drawing.Image)(resources.GetObject("btnAttachArtifact.Image")));
            this.btnAttachArtifact.Label = "Dokument anhängen";
            this.btnAttachArtifact.Name = "btnAttachArtifact";
            this.btnAttachArtifact.ScreenTip = "Bringen Sie Artefakte aus WiNPAT";
            this.btnAttachArtifact.ShowImage = true;
            this.btnAttachArtifact.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAttachArtifact_Click);
            // 
            // Winpat
            // 
            this.Name = "Winpat";
            this.RibbonType = "Microsoft.Outlook.Mail.Compose, Microsoft.Outlook.Mail.Read";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Winpat_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.grpWinpat.ResumeLayout(false);
            this.grpWinpat.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpWinpat;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAttachArtifact;
    }

    partial class ThisRibbonCollection
    {
        internal Winpat Winpat
        {
            get { return this.GetRibbon<Winpat>(); }
        }
    }
}
