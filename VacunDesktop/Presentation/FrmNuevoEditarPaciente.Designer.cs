namespace VacunDesktop.Presentation
{
    partial class FrmNuevoEditarPaciente
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
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblFechaDeNacimiento = new System.Windows.Forms.Label();
            this.LblDni = new System.Windows.Forms.Label();
            this.NUpDownDni = new System.Windows.Forms.NumericUpDown();
            this.DtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.CboTutor = new System.Windows.Forms.ComboBox();
            this.LblTutor = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.CboSexo = new System.Windows.Forms.ComboBox();
            this.LblSexo = new System.Windows.Forms.Label();
            this.CboCalendario = new System.Windows.Forms.ComboBox();
            this.LblCalendario = new System.Windows.Forms.Label();
            this.ChkPrematuro = new System.Windows.Forms.CheckBox();
            this.LblPeso = new System.Windows.Forms.Label();
            this.NudPeso = new System.Windows.Forms.NumericUpDown();
            this.TxtDomicilio = new System.Windows.Forms.TextBox();
            this.LblDomicilio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUpDownDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPeso)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtApellido
            // 
            this.TxtApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtApellido.Location = new System.Drawing.Point(321, 54);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(228, 29);
            this.TxtApellido.TabIndex = 1;
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblApellido.Location = new System.Drawing.Point(225, 54);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblApellido.Size = new System.Drawing.Size(70, 21);
            this.LblApellido.TabIndex = 1;
            this.LblApellido.Text = "Apellido:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNombre.Location = new System.Drawing.Point(225, 15);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblNombre.Size = new System.Drawing.Size(71, 21);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNombre.Location = new System.Drawing.Point(321, 12);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(228, 29);
            this.TxtNombre.TabIndex = 0;
            // 
            // LblFechaDeNacimiento
            // 
            this.LblFechaDeNacimiento.AutoSize = true;
            this.LblFechaDeNacimiento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFechaDeNacimiento.Location = new System.Drawing.Point(132, 215);
            this.LblFechaDeNacimiento.Name = "LblFechaDeNacimiento";
            this.LblFechaDeNacimiento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblFechaDeNacimiento.Size = new System.Drawing.Size(158, 21);
            this.LblFechaDeNacimiento.TabIndex = 1;
            this.LblFechaDeNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // LblDni
            // 
            this.LblDni.AutoSize = true;
            this.LblDni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDni.Location = new System.Drawing.Point(249, 102);
            this.LblDni.Name = "LblDni";
            this.LblDni.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblDni.Size = new System.Drawing.Size(40, 21);
            this.LblDni.TabIndex = 1;
            this.LblDni.Text = "DNI:";
            // 
            // NUpDownDni
            // 
            this.NUpDownDni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NUpDownDni.Location = new System.Drawing.Point(321, 100);
            this.NUpDownDni.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.NUpDownDni.Name = "NUpDownDni";
            this.NUpDownDni.Size = new System.Drawing.Size(228, 29);
            this.NUpDownDni.TabIndex = 2;
            // 
            // DtpFechaNacimiento
            // 
            this.DtpFechaNacimiento.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaNacimiento.Location = new System.Drawing.Point(321, 215);
            this.DtpFechaNacimiento.Name = "DtpFechaNacimiento";
            this.DtpFechaNacimiento.Size = new System.Drawing.Size(227, 23);
            this.DtpFechaNacimiento.TabIndex = 5;
            // 
            // CboTutor
            // 
            this.CboTutor.FormattingEnabled = true;
            this.CboTutor.Location = new System.Drawing.Point(321, 324);
            this.CboTutor.Name = "CboTutor";
            this.CboTutor.Size = new System.Drawing.Size(227, 23);
            this.CboTutor.TabIndex = 8;
            // 
            // LblTutor
            // 
            this.LblTutor.AutoSize = true;
            this.LblTutor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTutor.Location = new System.Drawing.Point(239, 322);
            this.LblTutor.Name = "LblTutor";
            this.LblTutor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblTutor.Size = new System.Drawing.Size(50, 21);
            this.LblTutor.TabIndex = 1;
            this.LblTutor.Text = "Tutor:";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(321, 415);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 10;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(455, 415);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 11;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // CboSexo
            // 
            this.CboSexo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CboSexo.FormattingEnabled = true;
            this.CboSexo.Location = new System.Drawing.Point(321, 173);
            this.CboSexo.Name = "CboSexo";
            this.CboSexo.Size = new System.Drawing.Size(228, 29);
            this.CboSexo.TabIndex = 4;
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSexo.Location = new System.Drawing.Point(243, 181);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblSexo.Size = new System.Drawing.Size(46, 21);
            this.LblSexo.TabIndex = 1;
            this.LblSexo.Text = "Sexo:";
            // 
            // CboCalendario
            // 
            this.CboCalendario.FormattingEnabled = true;
            this.CboCalendario.Location = new System.Drawing.Point(321, 370);
            this.CboCalendario.Name = "CboCalendario";
            this.CboCalendario.Size = new System.Drawing.Size(227, 23);
            this.CboCalendario.TabIndex = 9;
            // 
            // LblCalendario
            // 
            this.LblCalendario.AutoSize = true;
            this.LblCalendario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCalendario.Location = new System.Drawing.Point(208, 368);
            this.LblCalendario.Name = "LblCalendario";
            this.LblCalendario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblCalendario.Size = new System.Drawing.Size(88, 21);
            this.LblCalendario.TabIndex = 1;
            this.LblCalendario.Text = "Calendario:";
            // 
            // ChkPrematuro
            // 
            this.ChkPrematuro.AutoSize = true;
            this.ChkPrematuro.BackColor = System.Drawing.Color.Transparent;
            this.ChkPrematuro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChkPrematuro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChkPrematuro.Location = new System.Drawing.Point(321, 244);
            this.ChkPrematuro.Name = "ChkPrematuro";
            this.ChkPrematuro.Size = new System.Drawing.Size(103, 25);
            this.ChkPrematuro.TabIndex = 6;
            this.ChkPrematuro.Text = "Prematuro";
            this.ChkPrematuro.UseVisualStyleBackColor = false;
            // 
            // LblPeso
            // 
            this.LblPeso.AutoSize = true;
            this.LblPeso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPeso.Location = new System.Drawing.Point(249, 280);
            this.LblPeso.Name = "LblPeso";
            this.LblPeso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblPeso.Size = new System.Drawing.Size(45, 21);
            this.LblPeso.TabIndex = 1;
            this.LblPeso.Text = "Peso:";
            // 
            // NudPeso
            // 
            this.NudPeso.DecimalPlaces = 3;
            this.NudPeso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NudPeso.Location = new System.Drawing.Point(321, 278);
            this.NudPeso.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NudPeso.Name = "NudPeso";
            this.NudPeso.Size = new System.Drawing.Size(228, 29);
            this.NudPeso.TabIndex = 7;
            // 
            // TxtDomicilio
            // 
            this.TxtDomicilio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDomicilio.Location = new System.Drawing.Point(320, 135);
            this.TxtDomicilio.Name = "TxtDomicilio";
            this.TxtDomicilio.Size = new System.Drawing.Size(228, 29);
            this.TxtDomicilio.TabIndex = 3;
            // 
            // LblDomicilio
            // 
            this.LblDomicilio.AutoSize = true;
            this.LblDomicilio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDomicilio.Location = new System.Drawing.Point(224, 135);
            this.LblDomicilio.Name = "LblDomicilio";
            this.LblDomicilio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblDomicilio.Size = new System.Drawing.Size(79, 21);
            this.LblDomicilio.TabIndex = 1;
            this.LblDomicilio.Text = "Domicilio:";
            // 
            // FrmNuevoEditarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblDomicilio);
            this.Controls.Add(this.TxtDomicilio);
            this.Controls.Add(this.NudPeso);
            this.Controls.Add(this.LblPeso);
            this.Controls.Add(this.ChkPrematuro);
            this.Controls.Add(this.LblCalendario);
            this.Controls.Add(this.CboCalendario);
            this.Controls.Add(this.LblSexo);
            this.Controls.Add(this.CboSexo);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblTutor);
            this.Controls.Add(this.CboTutor);
            this.Controls.Add(this.DtpFechaNacimiento);
            this.Controls.Add(this.NUpDownDni);
            this.Controls.Add(this.LblDni);
            this.Controls.Add(this.LblFechaDeNacimiento);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.TxtApellido);
            this.Name = "FrmNuevoEditarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo/Editar Paciente";
            ((System.ComponentModel.ISupportInitialize)(this.NUpDownDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPeso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblFechaDeNacimiento;
        private System.Windows.Forms.Label LblDni;
        private System.Windows.Forms.NumericUpDown NUpDownDni;
        private System.Windows.Forms.DateTimePicker DtpFechaNacimiento;
        private System.Windows.Forms.ComboBox CboTutor;
        private System.Windows.Forms.Label LblTutor;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ComboBox CboSexo;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.ComboBox CboCalendario;
        private System.Windows.Forms.Label LblCalendario;
        private System.Windows.Forms.CheckBox ChkPrematuro;
        private System.Windows.Forms.Label LblPeso;
        private System.Windows.Forms.NumericUpDown NudPeso;
        private System.Windows.Forms.TextBox TxtDomicilio;
        private System.Windows.Forms.Label LblDomicilio;
    }
}