namespace Project_BookstoreManagement.PL
{
    partial class LiquidationReportUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.rpt_viewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpt_viewer
            // 
            this.rpt_viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpt_viewer.DocumentMapWidth = 1;
            this.rpt_viewer.LocalReport.ReportEmbeddedResource = "Project_BookstoreManagement.Reports.LiquidationReport.rdlc";
            this.rpt_viewer.Location = new System.Drawing.Point(0, 0);
            this.rpt_viewer.Name = "rpt_viewer";
            this.rpt_viewer.ServerReport.BearerToken = null;
            this.rpt_viewer.Size = new System.Drawing.Size(1151, 729);
            this.rpt_viewer.TabIndex = 2;
            this.rpt_viewer.Load += new System.EventHandler(this.rpt_viewer_Load);
            // 
            // LiquidationReportUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rpt_viewer);
            this.Name = "LiquidationReportUC";
            this.Size = new System.Drawing.Size(1151, 729);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpt_viewer;
    }
}
