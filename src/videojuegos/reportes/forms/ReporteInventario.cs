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
    public partial class ReporteInventario : Form
    {
        public ReporteInventario(List<Inventario> inventario)
        {
            InitializeComponent();
            var report = new ReportClass();
            report.FileName = @"C:\Users\PaulVeliz\Documents\Proyectos\alquiler-videojuegos\src\videojuegos\reportes\inventarios.rpt";
            report.Load();
            report.SetDataSource(inventario);

            crv.ReportSource = report;
            crv.Refresh();
        }
    }
}
