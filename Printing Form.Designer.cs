namespace Accounting_Invoice
{
    partial class Printing_Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportviewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport22 = new Accounting_Invoice.CrystalReport2();
            this.SuspendLayout();
            // 
            // reportviewer
            // 
            this.reportviewer.ActiveViewIndex = 0;
            this.reportviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportviewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportviewer.Location = new System.Drawing.Point(63, 57);
            this.reportviewer.Name = "reportviewer";
            this.reportviewer.ReportSource = this.CrystalReport22;
            this.reportviewer.Size = new System.Drawing.Size(1195, 840);
            this.reportviewer.TabIndex = 0;
            // 
            // Printing_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 920);
            this.Controls.Add(this.reportviewer);
            this.Name = "Printing_Form";
            this.Text = "Printing_Form";
            this.Load += new System.EventHandler(this.Printing_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportviewer;
        private CrystalReport2 CrystalReport22;
    }
}