
namespace VacunDesktop.Presentation
{
    partial class FrmNuevoEditarUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoEditarUsuario));
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuarioCompleto = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtNombreUsers = new System.Windows.Forms.TextBox();
            this.cboTipoUsuario = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(70, 61);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(110, 15);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Nombre Completo:";
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Location = new System.Drawing.Point(70, 96);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(113, 15);
            this.lblUsers.TabIndex = 1;
            this.lblUsers.Text = "Nombre de Usuario:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(110, 137);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(70, 15);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Location = new System.Drawing.Point(88, 178);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(92, 15);
            this.lblTipoUsuario.TabIndex = 3;
            this.lblTipoUsuario.Text = "Tipo de Usuario:";
            // 
            // txtNombreUsuarioCompleto
            // 
            this.txtNombreUsuarioCompleto.Location = new System.Drawing.Point(206, 61);
            this.txtNombreUsuarioCompleto.Name = "txtNombreUsuarioCompleto";
            this.txtNombreUsuarioCompleto.Size = new System.Drawing.Size(186, 23);
            this.txtNombreUsuarioCompleto.TabIndex = 0;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(206, 137);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(186, 23);
            this.txtContraseña.TabIndex = 2;
            // 
            // txtNombreUsers
            // 
            this.txtNombreUsers.Location = new System.Drawing.Point(206, 96);
            this.txtNombreUsers.Name = "txtNombreUsers";
            this.txtNombreUsers.Size = new System.Drawing.Size(186, 23);
            this.txtNombreUsers.TabIndex = 1;
            // 
            // cboTipoUsuario
            // 
            this.cboTipoUsuario.FormattingEnabled = true;
            this.cboTipoUsuario.Location = new System.Drawing.Point(206, 178);
            this.cboTipoUsuario.Name = "cboTipoUsuario";
            this.cboTipoUsuario.Size = new System.Drawing.Size(186, 23);
            this.cboTipoUsuario.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(88, 230);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 52);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar Usuario";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(228, 230);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 52);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmNuevoEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 294);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cboTipoUsuario);
            this.Controls.Add(this.txtNombreUsers);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtNombreUsuarioCompleto);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.lblNombreUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNuevoEditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar/Modificar Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuarioCompleto;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtNombreUsers;
        private System.Windows.Forms.ComboBox cboTipoUsuario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}