using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoPuntoDeVentasTresCapas
{
    public partial class FrmReporteVentasDiarias : Form
    {
        public FrmReporteVentasDiarias()
        {
            InitializeComponent();
        }

        private void FrmReporteVentasDiarias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'PuntoVentaPaqueteMedianoDataSet.SpRptVentasDiarias' Puede moverla o quitarla según sea necesario.
            this.SpRptVentasDiariasTableAdapter.Fill(this.PuntoVentaPaqueteMedianoDataSet.SpRptVentasDiarias);

            this.reportViewer1.RefreshReport();
        }
    }
}
