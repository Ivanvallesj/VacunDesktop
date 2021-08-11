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
    public partial class FrmNuevoEditarVacuna : Form, IFormBase
    {
        DbAdminVacunas dbAdminVacunas = new DbAdminVacunas();
        public int? IdEditar{ get; set; }
        public Vacuna vacuna { get; set; }
        public FrmNuevoEditarVacuna(int? idVacunaSeleccionada = null)
        {
            InitializeComponent();
            //si recibimos el idTutorSeleccionado significa que vamos a editar
            if (idVacunaSeleccionada != null)
            {
                IdEditar = idVacunaSeleccionada;
                //llamamos al metodo de carga datos
                CargarDatosEnPantalla();
                this.Text = "Editar Vacuna";
            }
            else
            {
                vacuna = new Vacuna();
                this.Text = "Nueva Vacuna";
            }
        }

        public void CargarDatosEnPantalla()
        {

                vacuna = (Vacuna)dbAdminVacunas.Obtener(IdEditar);
                TxtNombreV.Text = vacuna.Nombre;
                TxtBeneficios.Text = vacuna.Beneficios;
                NUpDownPeriodo.Value = vacuna.PeriodoAplicacion;
            

        }
        private void BtnGuardarV_Click(object sender, EventArgs e)
        {
                //le asignamos a sus propiedades el valor de cada uno de los cuadros de texto
                vacuna.Nombre = TxtNombreV.Text;
                vacuna.PeriodoAplicacion = Convert.ToInt32(NUpDownPeriodo.Value);
                vacuna.Beneficios = TxtBeneficios.Text;

                //si el id de la vacuna a editar es nulo agregamos una vacuna a la tabla
                if (IdEditar == null)
                    dbAdminVacunas.Agregar(vacuna);
                else //configuramos el almacenamiento de la modificacion si el id de la vacuna es distinto de nulo
                {
                    dbAdminVacunas.Actualizar(vacuna);
                }
            //cerramos el formulario
            this.Close();
        
        }

        private void BtnCancelarV_Click(object sender, EventArgs e)
        {
            //CAMINO POR SI ES UNA NUEVA VACUNA

            if (vacuna.Id == 0)

            {
                //length nos cuenta la cantidad de caracteres que hay en el string
                if (TxtNombreV.Text.Length == 0 && TxtBeneficios.Text.Length == 0 && NUpDownPeriodo.Value == 0)
                    this.Close();

                else
                {
                    PreguntarSiSaleSinGuardar();
                }
            }
            else  //CAMINO SI ES MODIFICANDO A UNA VACUNA EXISTENTE
            {
                if (CompararDatosFormularioConLosDeBBDD())
                    this.Close();
                else
                {
                    PreguntarSiSaleSinGuardar();
                }
            }
        }

        private bool CompararDatosFormularioConLosDeBBDD()
        {
            return (vacuna.Nombre == TxtNombreV.Text && vacuna.Beneficios == TxtBeneficios.Text && vacuna.PeriodoAplicacion == NUpDownPeriodo.Value);
        }

        private void PreguntarSiSaleSinGuardar()
        {
            DialogResult respuesta = MessageBox.Show($"¿Estas seguro que desea salir del formulario sin guardar los datos? ", "Datos sin Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                this.Close();
        }

        public void LimpiarDatosDeLaPantalla()
        {
            vacuna = new Vacuna();
            TxtNombreV.Text = "";
            TxtBeneficios.Text = "";
            NUpDownPeriodo.Value = 0;
            IdEditar = null;
        }
    }
}   


