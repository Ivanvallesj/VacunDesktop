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
    public partial class FrmCambioContrasena : Form
    {
        public int? IdActual { get; set; }
        Usuario usuario = new Usuario();
        public FrmCambioContrasena(int idSeleccionado)
        {
            InitializeComponent();
            
            if (idSeleccionado != 0)
            {
                IdActual = idSeleccionado;
                CargarCboUsuarioActual();
            }
        }

        private void CargarCboUsuarioActual()
        {
            using (var db = new VacunWebContext())
            {
                usuario = db.Usuarios.Find(IdActual);
                lblUsuarioActivo.Text = (usuario.User).ToUpper();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarContraseña_Click(object sender, EventArgs e)
        {
            CompararContraseñaActualConBBDD();
        }

        private void CompararContraseñaActualConBBDD()
        {
            if (HelperVacuna.ObtenerSha256Hash(txtContraseñaActual.Text) == usuario.Password)
            {
                if (txtContraseñaNueva.Text == txtConfirmacionContraseña.Text)
                {
                    using (var db = new VacunWebContext())
                    {
                        usuario.Password = HelperVacuna.ObtenerSha256Hash(txtContraseñaNueva.Text);
                        db.Entry(usuario).State = EntityState.Modified;
                        MessageBox.Show("Contraseña modificada con exito");
                        db.SaveChanges();
                        this.Close();
                    }
                }
                else 
                { 
                    MessageBox.Show("Las Contraseñas no coinciden");
                    VaciarCampos();
                }
                
            }
            else
            {
                MessageBox.Show("Contraseña Actual Incorrecta");
                VaciarCampos();
            }

        }
        private void VaciarCampos()
        {
            txtContraseñaActual.Text = "";
            txtContraseñaNueva.Text = "";
            txtConfirmacionContraseña.Text = "";
        }
    }
}
