
namespace VacunDesktop.Presentation
{
    partial class FrmGestionUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionUsuario));
            this.dataGridUsuarios = new System.Windows.Forms.DataGridView();
            this.BtnEliminarUsuario = new System.Windows.Forms.Button();
            this.BtnEditarUsuario = new System.Windows.Forms.Button();
            this.BtnAñadirUsuario = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridUsuarios
            // 
            this.dataGridUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUsuarios.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuarios.Location = new System.Drawing.Point(12, 42);
            this.dataGridUsuarios.Name = "dataGridUsuarios";
            this.dataGridUsuarios.ReadOnly = true;
            this.dataGridUsuarios.RowTemplate.Height = 25;
            this.dataGridUsuarios.Size = new System.Drawing.Size(712, 259);
            this.dataGridUsuarios.TabIndex = 0;
            // 
            // BtnEliminarUsuario
            // 
            this.BtnEliminarUsuario.Location = new System.Drawing.Point(280, 307);
            this.BtnEliminarUsuario.Name = "BtnEliminarUsuario";
            this.BtnEliminarUsuario.Size = new System.Drawing.Size(92, 35);
            this.BtnEliminarUsuario.TabIndex = 2;
            this.BtnEliminarUsuario.Text = "Eliminar";
            this.BtnEliminarUsuario.UseVisualStyleBackColor = true;
            this.BtnEliminarUsuario.Click += new System.EventHandler(this.BtnEliminarUsuario_Click);
            // 
            // BtnEditarUsuario
            // 
            this.BtnEditarUsuario.Location = new System.Drawing.Point(165, 307);
            this.BtnEditarUsuario.Name = "BtnEditarUsuario";
            this.BtnEditarUsuario.Size = new System.Drawing.Size(96, 35);
            this.BtnEditarUsuario.TabIndex = 1;
            this.BtnEditarUsuario.Text = "Editar";
            this.BtnEditarUsuario.UseVisualStyleBackColor = true;
            this.BtnEditarUsuario.Click += new System.EventHandler(this.BtnEditarUsuario_Click);
            // 
            // BtnAñadirUsuario
            // 
            this.BtnAñadirUsuario.Location = new System.Drawing.Point(51, 307);
            this.BtnAñadirUsuario.Name = "BtnAñadirUsuario";
            this.BtnAñadirUsuario.Size = new System.Drawing.Size(90, 35);
            this.BtnAñadirUsuario.TabIndex = 0;
            this.BtnAñadirUsuario.Text = "Añadir";
            this.BtnAñadirUsuario.UseVisualStyleBackColor = true;
            this.BtnAñadirUsuario.Click += new System.EventHandler(this.BtnAñadirUsuario_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(610, 322);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 35);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.Location = new System.Drawing.Point(404, 307);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(127, 35);
            this.btnCambiarContraseña.TabIndex = 4;
            this.btnCambiarContraseña.Text = "CambiarContraseña";
            this.btnCambiarContraseña.UseVisualStyleBackColor = true;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // FrmGestionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 364);
            this.Controls.Add(this.btnCambiarContraseña);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.BtnEliminarUsuario);
            this.Controls.Add(this.BtnEditarUsuario);
            this.Controls.Add(this.BtnAñadirUsuario);
            this.Controls.Add(this.dataGridUsuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGestionUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GESTION DE USUARIOS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridUsuarios;
        private System.Windows.Forms.Button BtnEliminarUsuario;
        private System.Windows.Forms.Button BtnEditarUsuario;
        private System.Windows.Forms.Button BtnAñadirUsuario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCambiarContraseña;
    }
}