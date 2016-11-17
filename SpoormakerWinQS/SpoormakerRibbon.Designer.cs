﻿namespace SpoormakerWinQS
{
    partial class SpoormakerRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public SpoormakerRibbon()
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
            this.tab1 = this.Factory.CreateRibbonTab();
            this.textProcessing = this.Factory.CreateRibbonGroup();
            this.tab2 = this.Factory.CreateRibbonTab();
            this.tab1.SuspendLayout();
            this.tab2.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.textProcessing);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // textProcessing
            // 
            this.textProcessing.Label = "Text File Processing";
            this.textProcessing.Name = "textProcessing";
            // 
            // tab2
            // 
            this.tab2.Label = "S&P WinQS";
            this.tab2.Name = "tab2";
            // 
            // SpoormakerRibbon
            // 
            this.Name = "SpoormakerRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Tabs.Add(this.tab2);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.SpoormakerRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup textProcessing;
        private Microsoft.Office.Tools.Ribbon.RibbonTab tab2;
    }

    partial class ThisRibbonCollection
    {
        internal SpoormakerRibbon SpoormakerRibbon
        {
            get { return this.GetRibbon<SpoormakerRibbon>(); }
        }
    }
}
