using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VacunDesktop.AdminData;
using VacunDesktop.Interfaces;
using VacunDesktop.Models;

namespace VacunDesktop.Presentation
{
    public partial class FrmNuevoEditarCalendario : Form , IFormBase
    {
        DbAdminCalendarios dbAdmin = new DbAdminCalendarios();
        public int? IdEditar { get; set; }

        public Calendario calendario = new Calendario();
        public FrmNuevoEditarCalendario(int? idSeleccionado=null)
        {
          
        InitializeComponent();

            LlenarComboSexo();
    
            //si recibimos el idCalendarioSeleccionado significa que vamos a editar
            if (idSeleccionado != null)
            {
                IdEditar = idSeleccionado;
                //llamamos al metodo de carga datos
                CargarDatosEnPantalla();
            }
            else
            {
                calendario = new Calendario();
            }

        }

        private void LlenarComboSexo()
        {
            cboSexo.DataSource = Enum.GetValues(typeof(SexoEnum));
        }

        public void CargarDatosEnPantalla()
        {
            //a traves del IdCalendarioEditar buscamos los datos del Calendario en el repositorio 
                calendario = (Calendario)dbAdmin.Obtener(IdEditar);
                TxtNombre.Text= calendario.Nombre;
                cboSexo.SelectedIndex = ((int)calendario.SexoPaciente)-1;
                chkPrematuro.Checked = calendario.PrematuroPaciente;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //le asignamos a sus propiedades el valor de cada uno de los cuadros de texto
            calendario.Nombre = TxtNombre.Text;
            calendario.SexoPaciente = (SexoEnum) cboSexo.SelectedValue;
            calendario.PrematuroPaciente = chkPrematuro.Checked;

            //si el id del Calendario a editar es nulo agregamos un Calendario a la tabla
            if (IdEditar == null)
                //lo agregamos al objeto Calendario al repositorio
                dbAdmin.Agregar(calendario);
            else //configuramos el almacenamiento de la modificacion si el id de Calendario es distinto de nulo
            {
                dbAdmin.Actualizar(calendario);
            }
            //cerramos el formulario
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //CAMINO POR SI ES UN NUEVO Calendario

            if (calendario.Id == 0)

            {
                //length nos cuenta la cantidad de caracteres que hay en el string
                if (TxtNombre.Text.Length == 0)
                    this.Close();

                else
                {
                    PreguntarSiSaleSinGuardar();
                }
            } else  //CAMINO SI ES MODIFICANDO A UN Calendario EXISTENTE
            {
                if (CompararDatosFormularioConLosDeBBDD())                    
                    this.Close();                    
                else
                {
                    PreguntarSiSaleSinGuardar();                   
                }
            }
        }

        private void PreguntarSiSaleSinGuardar()
        {
            DialogResult respuesta = MessageBox.Show($"¿Estas seguro que desea salir del formulario sin guardar los datos? ", "Datos sin Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                this.Close();
        }
        private bool CompararDatosFormularioConLosDeBBDD()
        {
            return (calendario.Nombre == TxtNombre.Text && calendario.SexoPaciente == (SexoEnum)cboSexo.SelectedValue && calendario.PrematuroPaciente == chkPrematuro.Checked);
        }
        public void LimpiarDatosDeLaPantalla()
        {
            calendario = new Calendario();
            TxtNombre.Text = "";
            cboSexo.SelectedIndex = 0;
            chkPrematuro.Checked = false;
            IdEditar = null;
        }
    }
}
