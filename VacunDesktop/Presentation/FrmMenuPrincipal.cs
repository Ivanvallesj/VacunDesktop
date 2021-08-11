using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VacunDesktop.AdminData;
using VacunDesktop.Models;

namespace VacunDesktop.Presentation
{
    public partial class FrmMenuPrincipal : Form
    {
        public static Usuario Usuario;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void mnuItemTutores_Click(object sender, EventArgs e)
        {
            //MECANISMO PARA LLAMAR A UN FORMULARIO Y MOSTRARLO EN PANTALLA
            var frmTutores = new FrmTutores();
            frmTutores.ShowDialog();
            
        }

        private void mnuItemVacuna_Click(object sender, EventArgs e)
        {
            //var frmVacuna = new FrmVacuna();
            //frmVacuna.ShowDialog();
            var frmVacuna = new FrmBase(new DbAdminVacunas(), new FrmNuevoEditarVacuna());
            frmVacuna.ShowDialog();
        }

        private void mnuItemSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hasta Luego");
            this.Close();
        }

        private void mnuCalendarios_Click(object sender, EventArgs e)
        {
            //var frmCalendarios = new FrmCalendarios(new DbAdminCalendarios());
            //frmCalendarios.ShowDialog();
            var frmCalendarios = new FrmBase(new DbAdminCalendarios(),new FrmNuevoEditarCalendario());
            frmCalendarios.ShowDialog();
        }

        private void MnuItemPacientes_Click(object sender, EventArgs e)
        {
            var frmPacientes = new FrmPacientes();
            frmPacientes.ShowDialog();
        }

        private void BtnTutores_Click(object sender, EventArgs e)
        {
            //MECANISMO PARA LLAMAR A UN FORMULARIO Y MOSTRARLO EN PANTALLA
            var frmTutores = new FrmTutores();
            frmTutores.ShowDialog();
        }

        private void BtnCalendarios_Click(object sender, EventArgs e)
        {
            var frmCalendarios = new FrmCalendarios(new DbAdminCalendarios());
            frmCalendarios.ShowDialog();
        }

        private void mnuListadoDeVacunas_Click(object sender, EventArgs e)
        {
            var frmListadoVacunas = new FrmListadoVacunas();
            frmListadoVacunas.ShowDialog();
        }

        private void mnuListadoCalendarios_Click(object sender, EventArgs e)
        {
            var frmListadoCalendarios = new FrmListadoCalendarios();
            frmListadoCalendarios.ShowDialog();
        }

        private void mnuCalendariosYVacunas_Click(object sender, EventArgs e)
        {
            var frmListadoCalendariosYVacunas = new FrmListadoCalendariosVacunas();
            frmListadoCalendariosYVacunas.ShowDialog();

        }

        private void FrmMenuPrincipal_Activated(object sender, EventArgs e)
        {
            if (Usuario == null)
            {
                //si no hay nadie logeado, entonces mostramos el formulario de Login
                var frmLogin = new FrmLogin(this);
                frmLogin.ShowDialog();
                if (Usuario != null)
                {
                    //dependiendo el tipo de usuario, habilitamos los distintos menues para que tengan acceso
                    MnuUsuario.Enabled = Usuario.TipoUsuario == TipoUsuarioEnum.Administrador ? true : false;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

            private void SubMnuUsuario_Click(object sender, EventArgs e)
        {
            var frmGestionUsuarios = new FrmGestionUsuario();
            frmGestionUsuarios.ShowDialog();
        }

        private void SubMnuCambioContraseña_Click(object sender, EventArgs e)
        {
            var frmCambioContraseña = new FrmCambioContrasena(FrmMenuPrincipal.Usuario.Id);
            frmCambioContraseña.ShowDialog();
        }
    }
}
