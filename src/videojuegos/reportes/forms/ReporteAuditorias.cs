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
    public partial class ReporteAuditorias : Form
    {
        public ReporteAuditorias(List<Auditoria> auditorias, DateTime fromt, DateTime to)
        {
            InitializeComponent();
            var rptH = new ReportClass();
            rptH.FileName = @"C:\Users\PaulVeliz\Documents\Proyectos\alquiler-videojuegos\src\videojuegos\reportes\auditorias.rpt";
            rptH.Load();
            rptH.SetDataSource(auditorias);

            rptH.SetParameterValue("fecha1", fromt.ToString("d"));
            rptH.SetParameterValue("fecha2", to.ToString("d"));

            crv.ReportSource = rptH;
            crv.Refresh();
        }
    }
}
