namespace VacunDesktop.Presentation
{
    partial class FrmNuevoEditarCalendario
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
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkPrematuro = new System.Windows.Forms.CheckBox();
            this.lblTituloCarga = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNombre.Location = new System.Drawing.Point(188, 79);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(228, 29);
            this.TxtNombre.TabIndex = 0;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.Transparent;
            this.LblNombre.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNombre.ForeColor = System.Drawing.Color.Black;
            this.LblNombre.Location = new System.Drawing.Point(97, 79);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(85, 25);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre:";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.Info;
            this.BtnGuardar.Location = new System.Drawing.Point(161, 241);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(111, 43);
            this.BtnGuardar.TabIndex = 3;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnCancelar.Location = new System.Drawing.Point(324, 241);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(128, 43);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // cboSexo
            // 
            this.cboSexo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Location = new System.Drawing.Point(188, 124);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(228, 29);
            this.cboSexo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(111, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sexo:";
            // 
            // chkPrematuro
            // 
            this.chkPrematuro.AutoSize = true;
            this.chkPrematuro.BackColor = System.Drawing.Color.Transparent;
            this.chkPrematuro.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkPrematuro.ForeColor = System.Drawing.Color.Black;
            this.chkPrematuro.Location = new System.Drawing.Point(241, 181);
            this.chkPrematuro.Name = "chkPrematuro";
            this.chkPrematuro.Size = new System.Drawing.Size(120, 29);
            this.chkPrematuro.TabIndex = 2;
            this.chkPrematuro.Text = "Prematuro";
            this.chkPrematuro.UseVisualStyleBackColor = false;
            // 
            // lblTituloCarga
            // 
            this.lblTituloCarga.AutoSize = true;
            this.lblTituloCarga.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloCarga.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTituloCarga.Location = new System.Drawing.Point(80, 9);
            this.lblTituloCarga.Name = "lblTituloCarga";
            this.lblTituloCarga.Size = new System.Drawing.Size(426, 25);
            this.lblTituloCarga.TabIndex = 7;
            this.lblTituloCarga.Text = "Complete la tabla para registrar un nuevo calendario";
            // 
            // FrmNuevoEditarCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 326);
            this.Controls.Add(this.lblTituloCarga);
            this.Controls.Add(this.chkPrematuro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSexo);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.TxtNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNuevoEditarCalendario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo/Editar Calendario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkPrematuro;
        private System.Windows.Forms.Label lblTituloCarga;
    }
}