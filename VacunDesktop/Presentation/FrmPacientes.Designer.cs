namespace VacunDesktop.Presentation
{
    partial class FrmPacientes
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
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.GridVacunas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.CboVacuna = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridVacunas)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(645, 117);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(234, 23);
            this.TxtBusqueda.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(591, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar :";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(775, 65);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(86, 30);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(686, 65);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(83, 30);
            this.BtnEditar.TabIndex = 2;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(600, 65);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(80, 30);
            this.BtnNuevo.TabIndex = 1;
            this.BtnNuevo.Text = "&Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // Grid
            // 
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(3, 12);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(582, 182);
            this.Grid.TabIndex = 0;
            this.Grid.Text = "dataGridView1";
            this.Grid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellEnter);
            // 
            // GridVacunas
            // 
            this.GridVacunas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridVacunas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.GridVacunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVacunas.Location = new System.Drawing.Point(3, 246);
            this.GridVacunas.Name = "GridVacunas";
            this.GridVacunas.ReadOnly = true;
            this.GridVacunas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridVacunas.Size = new System.Drawing.Size(582, 182);
            this.GridVacunas.TabIndex = 6;
            this.GridVacunas.Text = "dataGridView1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre de la Vacuna";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(319, 211);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(113, 33);
            this.BtnAgregar.TabIndex = 10;
            this.BtnAgregar.Text = "Agregar Vacuna";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // CboVacuna
            // 
            this.CboVacuna.FormattingEnabled = true;
            this.CboVacuna.Location = new System.Drawing.Point(22, 217);
            this.CboVacuna.Name = "CboVacuna";
            this.CboVacuna.Size = new System.Drawing.Size(269, 23);
            this.CboVacuna.TabIndex = 9;
            // 
            // FrmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.CboVacuna);
            this.Controls.Add(this.GridVacunas);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBusqueda);
            this.Name = "FrmPacientes";
            this.Text = "FrmPacientes";
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridVacunas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.DataGridView GridVacunas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.ComboBox CboVacuna;
    }
}