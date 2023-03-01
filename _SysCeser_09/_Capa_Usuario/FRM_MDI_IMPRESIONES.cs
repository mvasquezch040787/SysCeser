using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _PROYECTO_FINAL_LPV
{
    public partial class FRM_MDI_IMPRESIONES : Form
    {
        public FRM_MDI_IMPRESIONES()
        {
            InitializeComponent();
        }

        private void FRM_MDI_IMPRESIONES_Load(object sender, EventArgs e)
        {

        //Me.CRV.ReportSource = REPORTE
        //Me.MdiParent = PADRE
        //Me.Show()
        }
      public    void MDI_SHOW( object REPORT)
        {
            this.CRV.ReportSource = REPORT;
            this.Show();
        }

      private void timer1_Tick(object sender, EventArgs e)
      {

          this.CRV.RefreshReport();
            this.timer1 .Dispose();
        
      }
    }
}
