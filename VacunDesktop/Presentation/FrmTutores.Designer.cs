namespace VacunDesktop.Presentation
{
    partial class FrmTutores
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
            this.gridTutores = new System.Windows.Forms.DataGridView();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.GridPacientes = new System.Windows.Forms.DataGridView();
            this.BtnEliminarPaciente = new System.Windows.Forms.Button();
            this.BtnEditarPaciente = new System.Windows.Forms.Button();
            this.BtnAgregarPaciente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridTutores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTutores
            // 
            this.gridTutores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTutores.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridTutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTutores.Location = new System.Drawing.Point(12, 12);
            this.gridTutores.Name = "gridTutores";
            this.gridTutores.ReadOnly = true;
            this.gridTutores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTutores.Size = new System.Drawing.Size(640, 177);
            this.gridTutores.TabIndex = 0;
            this.gridTutores.Text = "dataGridView1";
            this.gridTutores.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTutores_CellEnter);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(658, 12);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(80, 30);
            this.BtnNuevo.TabIndex = 1;
            this.BtnNuevo.Text = "&Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(744, 12);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(83, 30);
            this.BtnEditar.TabIndex = 2;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(833, 12);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(86, 30);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // LblBuscar
            // 
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Location = new System.Drawing.Point(766, 112);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(45, 15);
            this.LblBuscar.TabIndex = 4;
            this.LblBuscar.Text = "Buscar ";
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(670, 130);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(249, 23);
            this.TxtBusqueda.TabIndex = 5;
            this.TxtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // GridPacientes
            // 
            this.GridPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridPacientes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.GridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPacientes.Location = new System.Drawing.Point(12, 223);
            this.GridPacientes.Name = "GridPacientes";
            this.GridPacientes.ReadOnly = true;
            this.GridPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPacientes.Size = new System.Drawing.Size(640, 177);
            this.GridPacientes.TabIndex = 0;
            this.GridPacientes.Text = "dataGridView1";
            // 
            // BtnEliminarPaciente
            // 
            this.BtnEliminarPaciente.Location = new System.Drawing.Point(429, 417);
            this.BtnEliminarPaciente.Name = "BtnEliminarPaciente";
            this.BtnEliminarPaciente.Size = new System.Drawing.Size(121, 30);
            this.BtnEliminarPaciente.TabIndex = 3;
            this.BtnEliminarPaciente.Text = "E&liminar Paciente";
            this.BtnEliminarPaciente.UseVisualStyleBackColor = true;
            // 
            // BtnEditarPaciente
            // 
            this.BtnEditarPaciente.Location = new System.Drawing.Point(263, 417);
            this.BtnEditarPaciente.Name = "BtnEditarPaciente";
            this.BtnEditarPaciente.Size = new System.Drawing.Size(105, 30);
            this.BtnEditarPaciente.TabIndex = 2;
            this.BtnEditarPaciente.Text = "&Editar Paciente";
            this.BtnEditarPaciente.UseVisualStyleBackColor = true;
            this.BtnEditarPaciente.Click += new System.EventHandler(this.BtnEditarPaciente_Click);
            // 
            // BtnAgregarPaciente
            // 
            this.BtnAgregarPaciente.Location = new System.Drawing.Point(82, 417);
            this.BtnAgregarPaciente.Name = "BtnAgregarPaciente";
            this.BtnAgregarPaciente.Size = new System.Drawing.Size(123, 30);
            this.BtnAgregarPaciente.TabIndex = 1;
            this.BtnAgregarPaciente.Text = "&Nuevo Paciente";
            this.BtnAgregarPaciente.UseVisualStyleBackColor = true;
            this.BtnAgregarPaciente.Click += new System.EventHandler(this.BtnAgregarPaciente_Click);
            // 
            // FrmTutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 479);
            this.Controls.Add(this.BtnAgregarPaciente);
            this.Controls.Add(this.BtnEditarPaciente);
            this.Controls.Add(this.BtnEliminarPaciente);
            this.Controls.Add(this.GridPacientes);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.LblBuscar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.gridTutores);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTutores";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutores";
            ((System.ComponentModel.ISupportInitialize)(this.gridTutores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTutores;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label LblBuscar;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.DataGridView GridPacientes;
        private System.Windows.Forms.Button BtnEliminarPaciente;
        private System.Windows.Forms.Button BtnEditarPaciente;
        private System.Windows.Forms.Button BtnAgregarPaciente;
    }
}