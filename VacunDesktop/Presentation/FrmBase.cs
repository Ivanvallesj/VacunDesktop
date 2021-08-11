using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VacunDesktop.ExtensionMethods;
using VacunDesktop.Interfaces;

namespace VacunDesktop.Presentation
{
    public partial class FrmBase : Form
    {
        IDbAdmin dbAdmin;
        IFormBase FrmNuevoEditar;
        public FrmBase(IDbAdmin objetoDbAdmin, IFormBase frmNuevoEditar)
        {
            InitializeComponent();
            dbAdmin = objetoDbAdmin;
            FrmNuevoEditar = frmNuevoEditar;
            ActualizarGrilla();
        }
        private void ActualizarGrilla()
        {
            grid.DataSource = dbAdmin.ObtenerTodos();
            grid.OcultarColumnas();
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            grid.DataSource = dbAdmin.ObtenerTodos(TxtBusqueda.Text);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoEditar.LimpiarDatosDeLaPantalla();
            FrmNuevoEditar.ShowDialog();

            //actualizamos la grilla
            ActualizarGrilla();

            //seleccionamos la fila del nuevo registro cargado, le pasamos al RowCount -1 para que reste una posicion porque todo comienza del 0
            grid.CurrentCell = grid.Rows[grid.RowCount - 1].Cells[0];

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

            //creamos la variable para saber que id de Calendario tenemos seleccionado
            var idSeleccionado = grid.ObtenerIdSeleccionado();
            var filaAEditar = grid.CurrentRow.Index;

            FrmNuevoEditar.IdEditar = idSeleccionado;
            FrmNuevoEditar.CargarDatosEnPantalla();
            FrmNuevoEditar.ShowDialog();


            //actualizamos la grilla
            ActualizarGrilla();

            //seleccionamos el registro editado
            grid.CurrentCell = grid.Rows[filaAEditar].Cells[0];

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //obtenemos el id y el nombre del Calendario seleccionado en la grilla
            var idSeleccionado = grid.ObtenerIdSeleccionado();

            //guardamos en la variable el nombre y el apellido del Calendario seleccionado
            var nombreCalendarioSeleccionado = grid.CurrentRow.Cells[1].Value.ToString();

            // preguntar si realmente desea eliminar al Calendario [nombre_Calendario_seleccionado]
            //colocamos el signo $ para crear la interpolacion de cadenas
            DialogResult respuesta = MessageBox.Show($"¿Estas seguro que desea eliminar a {nombreCalendarioSeleccionado}?", "Eliminar Calendario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //si responde que si, instanciamos al objeto dbContext y eliminamos el Calendario a traves del id que obtuvimos.
            if (respuesta == DialogResult.Yes)
            {
                dbAdmin.Eliminar(idSeleccionado);
                ActualizarGrilla();
            }
        }

        private void chkVerEliminados_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVerEliminados.Checked)
            {
                grid.DataSource = dbAdmin.ObtenerEliminados();
                //grid.OcultarColumnas();
                BtnEliminar.Text = "Restaurar";
            }
            else
            {
                ActualizarGrilla();
                BtnEliminar.Text = "Eliminar";
            }
           
            
        }
    }
}
