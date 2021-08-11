using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VacunDesktop.Models;

namespace VacunDesktop.Presentation
{
    public partial class FrmPacientes : Form
    {
        Paciente pacienteSeleccionado;
        public FrmPacientes()
        {
            InitializeComponent();
            ActualizarGrilla();
            
        }
        private void CargarCboVacunas(int? idCalendario)
        {
            using (var db = new VacunWebContext())
            {
                //columna que queiro que se muestre en pantalla 
                CboVacuna.DisplayMember = "nombre";
                //columna que quiere seleccionar para que obtenga el valor
                CboVacuna.ValueMember = "id";
                var listaVacunas = from vacuna in db.Vacunas
                                   join detalle in db.DetalleCalendarios
                                   on vacuna.Id equals detalle.VacunaId
                                   join calendario in db.Calendarios
                                   on detalle.CalendarioId equals calendario.Id
                                   where calendario.Id == idCalendario
                                   select new { id = vacuna.Id, nombre = vacuna.Nombre.Trim() };
                //cargamos el combo de tutores con los existentes en la base de datos
                CboVacuna.DataSource = listaVacunas.ToList();

                CboVacuna.SelectedValue = 0;
            }
        }
        private void ActualizarGrilla()
        {

            using (var db = new VacunWebContext())
            {
                //creamos una coleccion para seleccionar los datos que queremos mostrar en la grilla 
                var pacientesAListar = from paciente in db.Pacientes
                                       select new
                                       {
                                           id = paciente.Id,
                                           nombre = paciente.Nombre + " " + paciente.Apellido,
                                           FechaNacimiento = paciente.FechaNacimiento,
                                           Sexo = paciente.Sexo
                                       };
                Grid.DataSource = pacientesAListar.ToList();

            }

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            var frmNuevoEditarPaciente = new FrmNuevoEditarPaciente();
            frmNuevoEditarPaciente.ShowDialog();
            ActualizarGrilla();
            Grid.CurrentCell = Grid.Rows[Grid.RowCount - 1].Cells[0];
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //creamos la variable para saber que id de Calendario tenemos seleccionado
            var idSeleccionado = int.Parse(Grid.CurrentRow.Cells[0].Value.ToString());
            var filaAEditar = Grid.CurrentRow.Index;

            //abrimos el formulario para la edicion de un  Calendario
            var FrmNuevoEditarPaciente = new FrmNuevoEditarPaciente(idSeleccionado);
            FrmNuevoEditarPaciente.ShowDialog();

            //actualizamos la grilla
            ActualizarGrilla();

            //seleccionamos el registro editado
            Grid.CurrentCell = Grid.Rows[filaAEditar].Cells[0];
        }

        private void Grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //tomamos el id paciente
            var idPaciente = int.Parse(Grid.CurrentRow.Cells[0].Value.ToString());
            using var db = new VacunWebContext();
            this.pacienteSeleccionado = db.Pacientes.Find(idPaciente);
            CargarCboVacunas(this.pacienteSeleccionado.CalendarioId);
            CargarCboVacunasColocadas(idPaciente);
        }

        private void CargarCboVacunasColocadas(int idPaciente)
        {
            using (var db = new VacunWebContext())
            {
           
                var listaVacunasColocadas = from vacuna in db.Vacunas
                                           join colocada in db.VacunasColocadas
                                           on vacuna.Id equals colocada.VacunaId
                                           join paciente in db.Pacientes
                                           on colocada.PacienteId equals paciente.Id
                                           where paciente.Id == idPaciente
                                           select new { id = vacuna.Id, nombre = vacuna.Nombre.Trim(), fecha = colocada.Fecha.ToShortDateString() };
                GridVacunas.DataSource = listaVacunasColocadas.ToList();

                CboVacuna.SelectedValue = 0;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if ((int)CboVacuna.SelectedValue != 0){
                var idPaciente = int.Parse(Grid.CurrentRow.Cells[0].Value.ToString());
                var vacunaColocada = new VacunaColocada()
                {
                    PacienteId = idPaciente,
                    VacunaId = (int)CboVacuna.SelectedValue,
                    Fecha = DateTime.Now.Date
                };
                using var db = new VacunWebContext();
                db.VacunasColocadas.Add(vacunaColocada);
                db.SaveChanges();
                CargarCboVacunasColocadas(idPaciente);
            }
    
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
