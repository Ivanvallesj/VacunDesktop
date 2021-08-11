namespace VacunDesktop.Presentation
{
    partial class FrmVacuna
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
            this.gridVacunas = new System.Windows.Forms.DataGridView();
            this.BtnAñadirVacuna = new System.Windows.Forms.Button();
            this.BtnEditarVacuna = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.TxtBuscarVacuna = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridVacunas)).BeginInit();
            this.SuspendLayout();
            // 
            // gridVacunas
            // 
            this.gridVacunas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridVacunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVacunas.Location = new System.Drawing.Point(64, 12);
            this.gridVacunas.Name = "gridVacunas";
            this.gridVacunas.ReadOnly = true;
            this.gridVacunas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridVacunas.Size = new System.Drawing.Size(625, 269);
            this.gridVacunas.TabIndex = 0;
            this.gridVacunas.Text = "dataGridView1";
            // 
            // BtnAñadirVacuna
            // 
            this.BtnAñadirVacuna.Location = new System.Drawing.Point(85, 372);
            this.BtnAñadirVacuna.Name = "BtnAñadirVacuna";
            this.BtnAñadirVacuna.Size = new System.Drawing.Size(90, 35);
            this.BtnAñadirVacuna.TabIndex = 1;
            this.BtnAñadirVacuna.Text = "Añadir";
            this.BtnAñadirVacuna.UseVisualStyleBackColor = true;
            this.BtnAñadirVacuna.Click += new System.EventHandler(this.BtnAñadirVacuna_Click);
            // 
            // BtnEditarVacuna
            // 
            this.BtnEditarVacuna.Location = new System.Drawing.Point(218, 372);
            this.BtnEditarVacuna.Name = "BtnEditarVacuna";
            this.BtnEditarVacuna.Size = new System.Drawing.Size(96, 35);
            this.BtnEditarVacuna.TabIndex = 2;
            this.BtnEditarVacuna.Text = "Editar";
            this.BtnEditarVacuna.UseVisualStyleBackColor = true;
            this.BtnEditarVacuna.Click += new System.EventHandler(this.BtnEditarVacuna_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(364, 372);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(92, 35);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // LblBuscar
            // 
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Location = new System.Drawing.Point(85, 326);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(45, 15);
            this.LblBuscar.TabIndex = 4;
            this.LblBuscar.Text = "Buscar:";
            // 
            // TxtBuscarVacuna
            // 
            this.TxtBuscarVacuna.Location = new System.Drawing.Point(136, 323);
            this.TxtBuscarVacuna.Name = "TxtBuscarVacuna";
            this.TxtBuscarVacuna.Size = new System.Drawing.Size(391, 23);
            this.TxtBuscarVacuna.TabIndex = 5;
            this.TxtBuscarVacuna.TextChanged += new System.EventHandler(this.TxtBuscarVacuna_TextChanged);
            // 
            // FrmVacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtBuscarVacuna);
            this.Controls.Add(this.LblBuscar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditarVacuna);
            this.Controls.Add(this.BtnAñadirVacuna);
            this.Controls.Add(this.gridVacunas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVacuna";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Vacunas";
            ((System.ComponentModel.ISupportInitialize)(this.gridVacunas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridVacunas;
        private System.Windows.Forms.Button BtnAñadirVacuna;
        private System.Windows.Forms.Button BtnEditarVacuna;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label LblBuscar;
        private System.Windows.Forms.TextBox TxtBuscarVacuna;
    }
}