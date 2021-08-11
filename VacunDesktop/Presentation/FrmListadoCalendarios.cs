using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VacunDesktop.Models;

namespace VacunDesktop.Presentation
{
    public partial class FrmListadoCalendarios : Form
    {
        private readonly ReportViewer reporte;
        public FrmListadoCalendarios()
        {
            InitializeComponent();
            //instanciamos un visor de reportes
            reporte = new ReportViewer();
            //hacemos que ocupe todo el formulario
            reporte.Dock = DockStyle.Fill;
            //agregamos visualmente el visor de reportes al formulario
            Controls.Add(reporte);
        }

        private void FrmListadoCalendarios_Load(object sender, EventArgs e)
        {
            //abrumos el reporte utilizando la clase FileStream
            using var fs = new FileStream(@"..\..\..\reportes\ReporteCalendarios.rdlc", FileMode.Open);

            //asignamos el archivo a la propiedad LocalReport del objeto RepoViewer
            reporte.LocalReport.LoadReportDefinition(fs);

            //buscamos los datos que va a graficar el reporte
            using var db = new VacunWebContext();
            var calendarios = db.Calendarios.ToList();

            //asignamos los datos a la propiedad DataSources de Local Report utilizando un objeto de tipo ReportDataSource
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DataSetCalendarios",calendarios));

            reporte.RefreshReport();
        }
    }
}
