using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VacunDesktop.AdminData;
using VacunDesktop.ExtensionMethods;
using VacunDesktop.Models;

namespace VacunDesktop.Presentation
{
    public partial class FrmVacuna : Form
    {
        DbAdminVacunas dbAdminVacunas = new DbAdminVacunas();
        public FrmVacuna()
        {
            InitializeComponent();
            ActualizarGrillaVacuna();
        }

        private void ActualizarGrillaVacuna()
        {
            gridVacunas.DataSource = dbAdminVacunas.ObtenerTodos();
            gridVacunas.OcultarColumnas();
        }

        private void BtnAñadirVacuna_Click(object sender, EventArgs e)
        {
            var FrmNuevoEditarVacuna = new FrmNuevoEditarVacuna();
            FrmNuevoEditarVacuna.ShowDialog();
            ActualizarGrillaVacuna();
        }

        private void BtnEditarVacuna_Click(object sender, EventArgs e)
        {
            //creamos la variable para saber que id de vacuna tenemos seleccionado
            var idVacunaSeleccionada = gridVacunas.ObtenerIdSeleccionado();
            var filaAEditar = gridVacunas.CurrentRow.Index;

            //abrimos el formulario para la edicion de una Vacuna
            var FrmNuevoEditarVacuna = new FrmNuevoEditarVacuna(idVacunaSeleccionada);
            FrmNuevoEditarVacuna.ShowDialog();

            //actualizamos la grilla
            ActualizarGrillaVacuna();

            //seleccionamos el registro editado
            gridVacunas.CurrentCell = gridVacunas.Rows[filaAEditar].Cells[0];
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //obtenemos el id y el nombre de la vacuna seleccionada en la grilla
            //guardamos en la variable EL ID de la vacuna

            var idVacunaSeleccionada = gridVacunas.ObtenerIdSeleccionado();

            //guardamos en la variable el nombre de la vacuna
            var nombreVacunaSeleccionada = gridVacunas.CurrentRow.Cells[1].Value.ToString();

            // preguntar si realmente desea eliminar al tutor [nombre_tutor_seleccionado]
            //colocamos el signo $ para crear la interpolacion de cadenas
            DialogResult respuesta = MessageBox.Show($"¿Estas seguro que desea eliminar la vacuna{nombreVacunaSeleccionada}?", "Eliminar Vacuna", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //si responde que si, instanciamos al objeto dbContext y eliminamos el tutor a traves del id que obtuvimos.
            if (respuesta == DialogResult.Yes)
            {
                dbAdminVacunas.Eliminar(idVacunaSeleccionada);
                ActualizarGrillaVacuna();
            }
        }

        private void TxtBuscarVacuna_TextChanged(object sender, EventArgs e)
        {
            gridVacunas.DataSource = dbAdminVacunas.ObtenerTodos(TxtBuscarVacuna.Text);
        }
    }
}
