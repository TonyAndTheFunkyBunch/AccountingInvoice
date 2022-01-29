using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Accounting_Invoice
{
    public partial class Printing_Form : MetroForm
    {
        public Printing_Form()
        {
            InitializeComponent();
        }

        private void Printing_Form_Load(object sender, EventArgs e)
        {
            reportviewer.RefreshReport();
            CrystalReport2 objReport1 = new CrystalReport2();
            reportviewer.ReportSource = objReport1;
            reportviewer.RefreshReport();
        }
    }
}
