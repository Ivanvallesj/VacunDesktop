using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VacunDesktop.AdminData;
using VacunDesktop.Models;

namespace VacunDesktop.Presentation
{
    public partial class FrmNuevoEditarTutor : Form
    {
        DbAdminTutores dbAdminTutores = new DbAdminTutores();
        public int? IdTutorEditar { get; set; }
        public Tutor tutor { get; set; }
        public FrmNuevoEditarTutor(int? idTutorSeleccionado=null)
        {
          
        InitializeComponent();
            //si recibimos el idTutorSeleccionado significa que vamos a editar
            if (idTutorSeleccionado != null)
            {
                IdTutorEditar = idTutorSeleccionado;
                //llamamos al metodo de carga datos
                CargarDatosDelTutorEnPantalla();
            }
            else
            {
                tutor = new Tutor();
            }

        }

        private void CargarDatosDelTutorEnPantalla()
        {
            tutor = (Tutor)dbAdminTutores.Obtener(IdTutorEditar);
            TxtNombre.Text = tutor.Nombre;
            TxtApellido.Text = tutor.Apellido;
            TxtEmail.Text = tutor.Email;               
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {


                //le asignamos a sus propiedades el valor de cada uno de los cuadros de texto
                tutor.Apellido = TxtApellido.Text;
                tutor.Nombre = TxtNombre.Text;
                tutor.Email = TxtEmail.Text;

            //si el id del tutor a editar es nulo agregamos un tutor a la tabla
            if (IdTutorEditar == null)
                //lo agregamos al objeto Tutor al objeto DbCOntext
                dbAdminTutores.Agregar(tutor);
            else //configuramos el almacenamiento de la modificacion si el id de tutor es distinto de nulo
            {
                dbAdminTutores.Actualizar(tutor);
            }

            //cerramos el formulario
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //CAMINO POR SI ES UN NUEVO TUTOR

            if (tutor.Id == 0)

            {
                //length nos cuenta la cantidad de caracteres que hay en el string
                if (TxtApellido.Text.Length == 0 && TxtNombre.Text.Length == 0 && TxtEmail.Text.Length == 0)
                    this.Close();

                else
                {
                    PreguntarSiSaleSinGuardar();
                }
            } else  //CAMINO SI ES MODIFICANDO A UN TUTOR EXISTENTE
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
            return (tutor.Apellido == TxtApellido.Text && tutor.Nombre == TxtNombre.Text && tutor.Email == TxtEmail.Text);
        }
    }
}
