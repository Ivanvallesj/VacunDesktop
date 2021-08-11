
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using VacunDesktop.AdminData;
using VacunDesktop.ExtensionMethods;
using VacunDesktop.Models;

namespace VacunDesktop.Presentation
{
    public partial class FrmTutores : Form
    {
        DbAdminTutores dbAdminTutores = new DbAdminTutores();
        Tutor tutor { get; set; }

        //contructor (metodo que no devuelve valores que se llama igual que la clase
        public FrmTutores()
        {
            InitializeComponent();
            ActualizarGrilla();
        }

         private void ActualizarGrilla()
        {
            gridTutores.DataSource = dbAdminTutores.ObtenerTodos();
            gridTutores.OcultarColumnas();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            var frmNuevoEditarTutor = new FrmNuevoEditarTutor();
            frmNuevoEditarTutor.ShowDialog();
            //actualizamos la grilla
            ActualizarGrilla();
            //seleccionamos el registro editado
            gridTutores.CurrentCell = gridTutores.Rows[gridTutores.RowCount - 1].Cells[0];
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //creamos la variable para saber que id de tutor tenemos seleccionado
            var idTutorSeleccionado = gridTutores.ObtenerIdSeleccionado();
            var filaAEditar = gridTutores.CurrentRow.Index;

            //abrimos el formulario para la edicion de un  tutor
            var FrmNuevoEditarTutor = new FrmNuevoEditarTutor(idTutorSeleccionado);
            FrmNuevoEditarTutor.ShowDialog();

            //actualizamos la grilla
            ActualizarGrilla();

            //seleccionamos el registro editado
            gridTutores.CurrentCell = gridTutores.Rows[filaAEditar].Cells[0];        

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //obtenemos el id y el nombre del tutor seleccionado en la grilla
            var idTutorSeleccionado = gridTutores.ObtenerIdSeleccionado();

            //guardamos en la variable el nombre y el apellido del tutor seleccionado
            var nombreTutorSeleccionado = gridTutores.CurrentRow.Cells[1].Value.ToString() +" "+ gridTutores.CurrentRow.Cells[2].Value.ToString();

            // preguntar si realmente desea eliminar al tutor [nombre_tutor_seleccionado]
            //colocamos el signo $ para crear la interpolacion de cadenas
            DialogResult respuesta = MessageBox.Show($"¿Estas seguro que desea eliminar a {nombreTutorSeleccionado}?","Eliminar Tutor", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            //si responde que si, instanciamos al objeto dbContext y eliminamos el tutor a traves del id que obtuvimos.
            if (respuesta == DialogResult.Yes)
            {
                dbAdminTutores.Eliminar(idTutorSeleccionado);
                ActualizarGrilla();   
            }
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            gridTutores.DataSource = dbAdminTutores.ObtenerTodos(TxtBusqueda.Text);
        }

     
        private void gridTutores_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
                ActualizarGrillaPacientes();
        }

        private void BtnAgregarPaciente_Click(object sender, EventArgs e)
        {
            var frmNuevoEditarPaciente = new FrmNuevoEditarPaciente(tutor);
            frmNuevoEditarPaciente.ShowDialog();
            ActualizarGrillaPacientes();
            GridPacientes.CurrentCell = GridPacientes.Rows[GridPacientes.RowCount - 1].Cells[0];
        }

        private void ActualizarGrillaPacientes()
        {
            if (gridTutores.CurrentRow != null)
            {
                var idTutorSeleccionado = gridTutores.ObtenerIdSeleccionado();
                if (idTutorSeleccionado > 0)
                    {
                        using var db = new VacunWebContext();
                        tutor = (Tutor)db.Tutores.Where(t => t.Id == idTutorSeleccionado).Include(p => p.Pacientes).FirstOrDefault();
                        var pacientesAListar = from paciente in tutor.Pacientes
                                               select new
                                               {
                                                   id = paciente.Id,
                                                   nombre = paciente.Nombre + " " + paciente.Apellido,
                                                   FechaNacimiento = paciente.FechaNacimiento,
                                                   Sexo = paciente.Sexo
                                               };

                        GridPacientes.DataSource = pacientesAListar.ToList();
                    }
            }
        }

        private void BtnEditarPaciente_Click(object sender, EventArgs e)
        {
            //creamos la variable para saber que id de tutor tenemos seleccionado
            var idPacienteSeleccionado = int.Parse(GridPacientes.CurrentRow.Cells[0].Value.ToString());
            var filaAEditar = GridPacientes.CurrentRow.Index;

            //abrimos el formulario para la edicion de un  tutor
            var FrmNuevoEditarPaciente = new FrmNuevoEditarPaciente(tutor, idPacienteSeleccionado);
            FrmNuevoEditarPaciente.ShowDialog();

            //actualizamos la grilla
            ActualizarGrillaPacientes();

            //seleccionamos el registro editado
            gridTutores.CurrentCell = gridTutores.Rows[filaAEditar].Cells[0];
        }
    }
}
