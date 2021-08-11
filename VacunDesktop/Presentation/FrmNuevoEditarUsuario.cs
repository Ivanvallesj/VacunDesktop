using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VacunDesktop.Core;
using VacunDesktop.Models;

namespace VacunDesktop.Presentation
{
    public partial class FrmNuevoEditarUsuario : Form
    {
        public int? IdEditar { get; set; }
        Usuario usuario = new Usuario();
        public FrmNuevoEditarUsuario()
        {
            InitializeComponent();
            LlenarComboTipoUsuario();                
        }
        public FrmNuevoEditarUsuario(int idSeleccionado)
        {
            InitializeComponent();
            LlenarComboTipoUsuario();
            if (idSeleccionado != 0)
            {
                IdEditar = idSeleccionado;
                //llamamos al metodo de carga datos
                CargarDatosDelUsuario();
                txtContraseña.Enabled = false;
            }
        }

        private void CargarDatosDelUsuario()
        {
            using (var db = new VacunWebContext())
            {
                usuario = db.Usuarios.Find(IdEditar);
                txtNombreUsuarioCompleto.Text = usuario.Nombre;
                txtNombreUsers.Text = usuario.User;
                cboTipoUsuario.SelectedItem =usuario.TipoUsuario;
            }
        }

        private void LlenarComboTipoUsuario()
        {
           cboTipoUsuario.DataSource = Enum.GetValues(typeof(TipoUsuarioEnum));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //instanciamos un objeto DbContext
            using (var db = new VacunWebContext())
            {
                //le asignamos a sus propiedades el valor de cada uno de los cuadros de texto
                usuario.Nombre = txtNombreUsuarioCompleto.Text;
                usuario.User = txtNombreUsers.Text;
                usuario.TipoUsuario = (TipoUsuarioEnum)cboTipoUsuario.SelectedValue;
                //usuario.Password = HelperVacuna.ObtenerSha256Hash(txtContraseña.Text);
                if (IdEditar == null)
                { // agregamos el objeto Usuarios a la Base De datos
                    usuario.Password = HelperVacuna.ObtenerSha256Hash(txtContraseña.Text);
                    db.Usuarios.Add(usuario);
                    MessageBox.Show("Usuario " + usuario.Nombre + " cargado con exito");
                }
                else //configuramos el almacenamiento de la modificacion si el id del Usuario es distinto de nulo
                {
                    db.Entry(usuario).State = EntityState.Modified;
                    MessageBox.Show("Usuario " + usuario.Nombre + "  modificado con exito");
                }
                db.SaveChanges();
                this.Close();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
