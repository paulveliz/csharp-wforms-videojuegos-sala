using CrystalDecisions.CrystalReports.Engine;
using models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace videojuegos.reportes.forms
{
    public partial class TicketRenta : Form
    {
        public TicketRenta(Renta renta, List<RentaDetalle> rentaDetalle)
        {
            InitializeComponent();
            var report = new ReportClass();
            report.FileName = @"C:\Users\PaulVeliz\Documents\Proyectos\alquiler-videojuegos\src\videojuegos\reportes\ticketrenta.rpt";
            report.Load();
            report.SetDataSource(rentaDetalle);

            report.SetParameterValue("pCliente", renta.Cliente);
            report.SetParameterValue("pEmpleado", renta.Usuario);
            report.SetParameterValue("pTotal", renta.Total);
            report.SetParameterValue("pFecha", renta.Fecha);

            this.crv.ReportSource = report;
            this.crv.Refresh();
        }
    }
}
