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
    public partial class ReporteRentas : Form
    {
        public ReporteRentas(List<Renta> rentas, DateTime fromt, DateTime to)
        {
            InitializeComponent();
            var report = new ReportClass();
            report.FileName = @"C:\Users\PaulVeliz\Documents\Proyectos\alquiler-videojuegos\src\videojuegos\reportes\rentas.rpt";
            report.Load();
            report.SetDataSource(rentas);

            report.SetParameterValue("fecha1", fromt.ToString("d"));
            report.SetParameterValue("fecha2", to.ToString("d"));

            this.crv.ReportSource = report;
            this.crv.Refresh();
        }
    }
}
