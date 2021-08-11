namespace VacunDesktop.Presentation
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuItemPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemTutores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCalendarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemListado = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemVacuna = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListadoDeVacunas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListadoCalendarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCalendariosYVacunas = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMnuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMnuCambioContraseña = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.BtnTutores = new System.Windows.Forms.ToolStripButton();
            this.BtnCalendarios = new System.Windows.Forms.ToolStripButton();
            this.menuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BarraHerramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemPrincipal,
            this.mnuItemListado,
            this.MnuUsuario,
            this.mnuItemSalir});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(826, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // mnuItemPrincipal
            // 
            this.mnuItemPrincipal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemTutores,
            this.mnuCalendarios,
            this.MnuItemPacientes});
            this.mnuItemPrincipal.Name = "mnuItemPrincipal";
            this.mnuItemPrincipal.Size = new System.Drawing.Size(65, 20);
            this.mnuItemPrincipal.Text = "Principal";
            // 
            // mnuItemTutores
            // 
            this.mnuItemTutores.Name = "mnuItemTutores";
            this.mnuItemTutores.Size = new System.Drawing.Size(136, 22);
            this.mnuItemTutores.Text = "Tutores";
            this.mnuItemTutores.Click += new System.EventHandler(this.mnuItemTutores_Click);
            // 
            // mnuCalendarios
            // 
            this.mnuCalendarios.Name = "mnuCalendarios";
            this.mnuCalendarios.Size = new System.Drawing.Size(136, 22);
            this.mnuCalendarios.Text = "Calendarios";
            this.mnuCalendarios.Click += new System.EventHandler(this.mnuCalendarios_Click);
            // 
            // MnuItemPacientes
            // 
            this.MnuItemPacientes.Name = "MnuItemPacientes";
            this.MnuItemPacientes.Size = new System.Drawing.Size(136, 22);
            this.MnuItemPacientes.Text = "Pacientes";
            this.MnuItemPacientes.Click += new System.EventHandler(this.MnuItemPacientes_Click);
            // 
            // mnuItemListado
            // 
            this.mnuItemListado.AutoSize = false;
            this.mnuItemListado.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemVacuna,
            this.mnuListadoDeVacunas,
            this.mnuListadoCalendarios,
            this.mnuCalendariosYVacunas});
            this.mnuItemListado.Name = "mnuItemListado";
            this.mnuItemListado.Size = new System.Drawing.Size(57, 20);
            this.mnuItemListado.Text = "Listado";
            // 
            // mnuItemVacuna
            // 
            this.mnuItemVacuna.Name = "mnuItemVacuna";
            this.mnuItemVacuna.Size = new System.Drawing.Size(232, 22);
            this.mnuItemVacuna.Text = "Vacunas";
            this.mnuItemVacuna.Click += new System.EventHandler(this.mnuItemVacuna_Click);
            // 
            // mnuListadoDeVacunas
            // 
            this.mnuListadoDeVacunas.Name = "mnuListadoDeVacunas";
            this.mnuListadoDeVacunas.Size = new System.Drawing.Size(232, 22);
            this.mnuListadoDeVacunas.Text = "Listado de vacunas";
            this.mnuListadoDeVacunas.Click += new System.EventHandler(this.mnuListadoDeVacunas_Click);
            // 
            // mnuListadoCalendarios
            // 
            this.mnuListadoCalendarios.Name = "mnuListadoCalendarios";
            this.mnuListadoCalendarios.Size = new System.Drawing.Size(232, 22);
            this.mnuListadoCalendarios.Text = "Listado de Calendarios";
            this.mnuListadoCalendarios.Click += new System.EventHandler(this.mnuListadoCalendarios_Click);
            // 
            // mnuCalendariosYVacunas
            // 
            this.mnuCalendariosYVacunas.Name = "mnuCalendariosYVacunas";
            this.mnuCalendariosYVacunas.Size = new System.Drawing.Size(232, 22);
            this.mnuCalendariosYVacunas.Text = "Listado Calendarios y Vacunas";
            this.mnuCalendariosYVacunas.Click += new System.EventHandler(this.mnuCalendariosYVacunas_Click);
            // 
            // MnuUsuario
            // 
            this.MnuUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMnuUsuario,
            this.SubMnuCambioContraseña});
            this.MnuUsuario.Name = "MnuUsuario";
            this.MnuUsuario.Size = new System.Drawing.Size(123, 20);
            this.MnuUsuario.Text = "Gestion de Usuarios";
            // 
            // SubMnuUsuario
            // 
            this.SubMnuUsuario.Name = "SubMnuUsuario";
            this.SubMnuUsuario.Size = new System.Drawing.Size(195, 22);
            this.SubMnuUsuario.Text = "Usuarios";
            this.SubMnuUsuario.Click += new System.EventHandler(this.SubMnuUsuario_Click);
            // 
            // SubMnuCambioContraseña
            // 
            this.SubMnuCambioContraseña.Name = "SubMnuCambioContraseña";
            this.SubMnuCambioContraseña.Size = new System.Drawing.Size(195, 22);
            this.SubMnuCambioContraseña.Text = "Cambio de Contraseña";
            this.SubMnuCambioContraseña.Click += new System.EventHandler(this.SubMnuCambioContraseña_Click);
            // 
            // mnuItemSalir
            // 
            this.mnuItemSalir.Name = "mnuItemSalir";
            this.mnuItemSalir.Size = new System.Drawing.Size(41, 20);
            this.mnuItemSalir.Text = "Salir";
            this.mnuItemSalir.Click += new System.EventHandler(this.mnuItemSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::VacunDesktop.Properties.Resources.Fondo2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(826, 444);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BarraHerramientas
            // 
            this.BarraHerramientas.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.BarraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnTutores,
            this.BtnCalendarios});
            this.BarraHerramientas.Location = new System.Drawing.Point(0, 24);
            this.BarraHerramientas.Name = "BarraHerramientas";
            this.BarraHerramientas.Size = new System.Drawing.Size(826, 47);
            this.BarraHerramientas.TabIndex = 3;
            this.BarraHerramientas.Text = "toolStrip1";
            // 
            // BtnTutores
            // 
            this.BtnTutores.Image = ((System.Drawing.Image)(resources.GetObject("BtnTutores.Image")));
            this.BtnTutores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnTutores.Name = "BtnTutores";
            this.BtnTutores.Size = new System.Drawing.Size(50, 44);
            this.BtnTutores.Text = "Tutores";
            this.BtnTutores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnTutores.ToolTipText = "Gestion de Tutores";
            this.BtnTutores.Click += new System.EventHandler(this.BtnTutores_Click);
            // 
            // BtnCalendarios
            // 
            this.BtnCalendarios.Image = ((System.Drawing.Image)(resources.GetObject("BtnCalendarios.Image")));
            this.BtnCalendarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCalendarios.Name = "BtnCalendarios";
            this.BtnCalendarios.Size = new System.Drawing.Size(73, 44);
            this.BtnCalendarios.Text = "Calendarios";
            this.BtnCalendarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCalendarios.ToolTipText = "Gestion de Calendarios";
            this.BtnCalendarios.Click += new System.EventHandler(this.BtnCalendarios_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 468);
            this.Controls.Add(this.BarraHerramientas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FrmMenuPrincipal";
            this.Text = "Aplicacion de escritorio de Vacunas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FrmMenuPrincipal_Activated);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BarraHerramientas.ResumeLayout(false);
            this.BarraHerramientas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuItemPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuItemTutores;
        private System.Windows.Forms.ToolStripMenuItem mnuItemListado;
        private System.Windows.Forms.ToolStripMenuItem mnuItemSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem mnuItemVacuna;
        private System.Windows.Forms.ToolStripMenuItem mnuCalendarios;
        private System.Windows.Forms.ToolStripMenuItem MnuItemPacientes;
        private System.Windows.Forms.ToolStrip BarraHerramientas;
        private System.Windows.Forms.ToolStripButton BtnTutores;
        private System.Windows.Forms.ToolStripButton BtnCalendarios;
        private System.Windows.Forms.ToolStripMenuItem mnuListadoDeVacunas;
        private System.Windows.Forms.ToolStripMenuItem mnuListadoCalendarios;
        private System.Windows.Forms.ToolStripMenuItem mnuCalendariosYVacunas;
        private System.Windows.Forms.ToolStripMenuItem MnuUsuario;
        private System.Windows.Forms.ToolStripMenuItem SubMnuUsuario;
        private System.Windows.Forms.ToolStripMenuItem SubMnuCambioContraseña;
    }
}

