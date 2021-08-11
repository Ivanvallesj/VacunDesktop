using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VacunDesktop.Core;
using VacunDesktop.Models;

namespace VacunDesktop.Presentation
{
    public partial class FrmLogin : Form
    {
        int intentosFallidos = 0;
        int intentosMaximos = 3;
        int intentosRestantes;
        public FrmMenuPrincipal FrmMenuPrincipal;
        public FrmLogin(FrmMenuPrincipal frmPrincipal)
        {
            InitializeComponent();
            FrmMenuPrincipal = frmPrincipal;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Acceder();
        }

        private void Acceder()
        {
            if (ValidarAcceso())
                this.Close();
            else
            {
                intentosFallidos++;
                intentosRestantes = intentosMaximos - intentosFallidos;
                if (intentosFallidos == 3)
                    this.Close();
                else
                {
                    MessageBox.Show($"Error en ingresar, usuario o contraseña incorrectos, te quedan {intentosRestantes} intentos");

                    txtUsuario.Text = "";
                    txtPassword.Text = "";
                }
            }
        }

        private bool ValidarAcceso()
        {
            using var db = new VacunWebContext();
            string pass = HelperVacuna.ObtenerSha256Hash(txtPassword.Text);
            var listaUsuarios = db.Usuarios.Where(u => u.User.Equals(txtUsuario.Text)).Where(u => u.Password.Equals(pass)).ToList();
            if (listaUsuarios.Count > 0)
            {
                FrmMenuPrincipal.Usuario = listaUsuarios.ElementAt(0);            
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
