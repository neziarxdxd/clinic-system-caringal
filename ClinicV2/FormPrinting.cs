using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicV2
{
    public partial class FormPrinting : Form
    {
        public FormPrinting()
        {
            InitializeComponent();
        }

        private void FormPrinting_Load(object sender, EventArgs e)
        {

            this.reportViewerGeneratePrint.RefreshReport();
            reportViewerGeneratePrint.RefreshReport();
            reportViewerGeneratePrint.Refresh();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
