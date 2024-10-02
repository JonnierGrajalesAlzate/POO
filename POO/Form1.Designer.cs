namespace POO
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbCarro = new System.Windows.Forms.GroupBox();
            this.btnEnviarCarro = new System.Windows.Forms.Button();
            this.lblNumeroPlazas = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNumeroLicencia = new System.Windows.Forms.Label();
            this.txtNumeroLicencia = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNumeroPlazas = new System.Windows.Forms.TextBox();
            this.lblPotencia = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtPotenciaCaballos = new System.Windows.Forms.TextBox();
            this.gbProfesor = new System.Windows.Forms.GroupBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnEliminarProfesor = new System.Windows.Forms.Button();
            this.btnModificarProfesor = new System.Windows.Forms.Button();
            this.btnAceptarProfesor = new System.Windows.Forms.Button();
            this.lblAniosServicio = new System.Windows.Forms.Label();
            this.txtAniosServicio = new System.Windows.Forms.TextBox();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.txtFinContrato = new System.Windows.Forms.TextBox();
            this.lblDedicacion = new System.Windows.Forms.Label();
            this.txtDedicacion = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.gbCarro.SuspendLayout();
            this.gbProfesor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCarro
            // 
            this.gbCarro.BackColor = System.Drawing.SystemColors.Control;
            this.gbCarro.Controls.Add(this.btnEnviarCarro);
            this.gbCarro.Controls.Add(this.lblNumeroPlazas);
            this.gbCarro.Controls.Add(this.lblMatricula);
            this.gbCarro.Controls.Add(this.lblNumeroLicencia);
            this.gbCarro.Controls.Add(this.txtNumeroLicencia);
            this.gbCarro.Controls.Add(this.txtMatricula);
            this.gbCarro.Controls.Add(this.txtNumeroPlazas);
            this.gbCarro.Controls.Add(this.lblPotencia);
            this.gbCarro.Controls.Add(this.txtModelo);
            this.gbCarro.Controls.Add(this.lblModelo);
            this.gbCarro.Controls.Add(this.txtPotenciaCaballos);
            this.gbCarro.Location = new System.Drawing.Point(12, 12);
            this.gbCarro.Name = "gbCarro";
            this.gbCarro.Size = new System.Drawing.Size(455, 170);
            this.gbCarro.TabIndex = 0;
            this.gbCarro.TabStop = false;
            this.gbCarro.Text = "Carro";
            // 
            // btnEnviarCarro
            // 
            this.btnEnviarCarro.Location = new System.Drawing.Point(182, 128);
            this.btnEnviarCarro.Name = "btnEnviarCarro";
            this.btnEnviarCarro.Size = new System.Drawing.Size(75, 23);
            this.btnEnviarCarro.TabIndex = 15;
            this.btnEnviarCarro.Text = "Enviar";
            this.btnEnviarCarro.UseVisualStyleBackColor = true;
            this.btnEnviarCarro.Click += new System.EventHandler(this.btnEnviarCarro_Click);
            // 
            // lblNumeroPlazas
            // 
            this.lblNumeroPlazas.AutoSize = true;
            this.lblNumeroPlazas.Location = new System.Drawing.Point(243, 65);
            this.lblNumeroPlazas.Name = "lblNumeroPlazas";
            this.lblNumeroPlazas.Size = new System.Drawing.Size(95, 13);
            this.lblNumeroPlazas.TabIndex = 14;
            this.lblNumeroPlazas.Text = "Número de plazas:";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(6, 32);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(57, 13);
            this.lblMatricula.TabIndex = 6;
            this.lblMatricula.Text = "*Matricula:";
            // 
            // lblNumeroLicencia
            // 
            this.lblNumeroLicencia.AutoSize = true;
            this.lblNumeroLicencia.Location = new System.Drawing.Point(243, 32);
            this.lblNumeroLicencia.Name = "lblNumeroLicencia";
            this.lblNumeroLicencia.Size = new System.Drawing.Size(101, 13);
            this.lblNumeroLicencia.TabIndex = 13;
            this.lblNumeroLicencia.Text = "Número de licencia:";
            // 
            // txtNumeroLicencia
            // 
            this.txtNumeroLicencia.Location = new System.Drawing.Point(344, 29);
            this.txtNumeroLicencia.Name = "txtNumeroLicencia";
            this.txtNumeroLicencia.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroLicencia.TabIndex = 11;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(98, 32);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 1;
            // 
            // txtNumeroPlazas
            // 
            this.txtNumeroPlazas.Location = new System.Drawing.Point(344, 62);
            this.txtNumeroPlazas.Name = "txtNumeroPlazas";
            this.txtNumeroPlazas.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroPlazas.TabIndex = 12;
            // 
            // lblPotencia
            // 
            this.lblPotencia.AutoSize = true;
            this.lblPotencia.Location = new System.Drawing.Point(6, 90);
            this.lblPotencia.Name = "lblPotencia";
            this.lblPotencia.Size = new System.Drawing.Size(88, 13);
            this.lblPotencia.TabIndex = 8;
            this.lblPotencia.Text = "*Potencia en CV:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(98, 60);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 2;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(6, 60);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(49, 13);
            this.lblModelo.TabIndex = 7;
            this.lblModelo.Text = "*Modelo:";
            // 
            // txtPotenciaCaballos
            // 
            this.txtPotenciaCaballos.Location = new System.Drawing.Point(98, 90);
            this.txtPotenciaCaballos.Name = "txtPotenciaCaballos";
            this.txtPotenciaCaballos.Size = new System.Drawing.Size(100, 20);
            this.txtPotenciaCaballos.TabIndex = 5;
            // 
            // gbProfesor
            // 
            this.gbProfesor.BackColor = System.Drawing.SystemColors.Control;
            this.gbProfesor.Controls.Add(this.btnListar);
            this.gbProfesor.Controls.Add(this.btnEliminarProfesor);
            this.gbProfesor.Controls.Add(this.btnModificarProfesor);
            this.gbProfesor.Controls.Add(this.btnAceptarProfesor);
            this.gbProfesor.Controls.Add(this.lblAniosServicio);
            this.gbProfesor.Controls.Add(this.txtAniosServicio);
            this.gbProfesor.Controls.Add(this.lblFechaFin);
            this.gbProfesor.Controls.Add(this.txtInicio);
            this.gbProfesor.Controls.Add(this.lblFechaInicio);
            this.gbProfesor.Controls.Add(this.txtFinContrato);
            this.gbProfesor.Controls.Add(this.lblDedicacion);
            this.gbProfesor.Controls.Add(this.txtDedicacion);
            this.gbProfesor.Controls.Add(this.lblNombre);
            this.gbProfesor.Controls.Add(this.txtNombre);
            this.gbProfesor.Controls.Add(this.lblCedula);
            this.gbProfesor.Controls.Add(this.txtApellidos);
            this.gbProfesor.Controls.Add(this.lblApellidos);
            this.gbProfesor.Controls.Add(this.txtCedula);
            this.gbProfesor.Location = new System.Drawing.Point(12, 205);
            this.gbProfesor.Name = "gbProfesor";
            this.gbProfesor.Size = new System.Drawing.Size(455, 199);
            this.gbProfesor.TabIndex = 16;
            this.gbProfesor.TabStop = false;
            this.gbProfesor.Text = "Profesor";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(379, 158);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(65, 24);
            this.btnListar.TabIndex = 19;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnEliminarProfesor
            // 
            this.btnEliminarProfesor.Location = new System.Drawing.Point(205, 159);
            this.btnEliminarProfesor.Name = "btnEliminarProfesor";
            this.btnEliminarProfesor.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarProfesor.TabIndex = 18;
            this.btnEliminarProfesor.Text = "Eliminar";
            this.btnEliminarProfesor.UseVisualStyleBackColor = true;
            this.btnEliminarProfesor.Click += new System.EventHandler(this.btnEliminarProfesor_Click);
            // 
            // btnModificarProfesor
            // 
            this.btnModificarProfesor.Location = new System.Drawing.Point(114, 159);
            this.btnModificarProfesor.Name = "btnModificarProfesor";
            this.btnModificarProfesor.Size = new System.Drawing.Size(75, 23);
            this.btnModificarProfesor.TabIndex = 17;
            this.btnModificarProfesor.Text = "Modificar";
            this.btnModificarProfesor.UseVisualStyleBackColor = true;
            this.btnModificarProfesor.Click += new System.EventHandler(this.btnModificarProfesor_Click);
            // 
            // btnAceptarProfesor
            // 
            this.btnAceptarProfesor.Location = new System.Drawing.Point(19, 159);
            this.btnAceptarProfesor.Name = "btnAceptarProfesor";
            this.btnAceptarProfesor.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarProfesor.TabIndex = 16;
            this.btnAceptarProfesor.Text = "Incluir";
            this.btnAceptarProfesor.UseVisualStyleBackColor = true;
            this.btnAceptarProfesor.Click += new System.EventHandler(this.btnAceptarProfesor_Click);
            // 
            // lblAniosServicio
            // 
            this.lblAniosServicio.AutoSize = true;
            this.lblAniosServicio.Location = new System.Drawing.Point(243, 99);
            this.lblAniosServicio.Name = "lblAniosServicio";
            this.lblAniosServicio.Size = new System.Drawing.Size(88, 13);
            this.lblAniosServicio.TabIndex = 16;
            this.lblAniosServicio.Text = "Años de servicio:";
            // 
            // txtAniosServicio
            // 
            this.txtAniosServicio.Location = new System.Drawing.Point(344, 96);
            this.txtAniosServicio.Name = "txtAniosServicio";
            this.txtAniosServicio.Size = new System.Drawing.Size(100, 20);
            this.txtAniosServicio.TabIndex = 15;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(243, 65);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(96, 13);
            this.lblFechaFin.TabIndex = 14;
            this.lblFechaFin.Text = "Fecha fin contrato:";
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(344, 29);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(100, 20);
            this.txtInicio.TabIndex = 11;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(243, 32);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(78, 13);
            this.lblFechaInicio.TabIndex = 13;
            this.lblFechaInicio.Text = "Fecha Ingreso:";
            // 
            // txtFinContrato
            // 
            this.txtFinContrato.Location = new System.Drawing.Point(344, 62);
            this.txtFinContrato.Name = "txtFinContrato";
            this.txtFinContrato.Size = new System.Drawing.Size(100, 20);
            this.txtFinContrato.TabIndex = 12;
            // 
            // lblDedicacion
            // 
            this.lblDedicacion.AutoSize = true;
            this.lblDedicacion.Location = new System.Drawing.Point(6, 124);
            this.lblDedicacion.Name = "lblDedicacion";
            this.lblDedicacion.Size = new System.Drawing.Size(68, 13);
            this.lblDedicacion.TabIndex = 10;
            this.lblDedicacion.Text = "*Dedicación:";
            // 
            // txtDedicacion
            // 
            this.txtDedicacion.Location = new System.Drawing.Point(98, 124);
            this.txtDedicacion.Name = "txtDedicacion";
            this.txtDedicacion.Size = new System.Drawing.Size(100, 20);
            this.txtDedicacion.TabIndex = 9;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "*Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(98, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(6, 90);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(44, 13);
            this.lblCedula.TabIndex = 8;
            this.lblCedula.Text = "*Cédula";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(98, 57);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtApellidos.TabIndex = 2;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(6, 60);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(56, 13);
            this.lblApellidos.TabIndex = 7;
            this.lblApellidos.Text = "*Apellidos:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(98, 90);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(483, 420);
            this.Controls.Add(this.gbProfesor);
            this.Controls.Add(this.gbCarro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbCarro.ResumeLayout(false);
            this.gbCarro.PerformLayout();
            this.gbProfesor.ResumeLayout(false);
            this.gbProfesor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCarro;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtPotenciaCaballos;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblPotencia;
        private System.Windows.Forms.Label lblNumeroPlazas;
        private System.Windows.Forms.Label lblNumeroLicencia;
        private System.Windows.Forms.TextBox txtNumeroLicencia;
        private System.Windows.Forms.TextBox txtNumeroPlazas;
        private System.Windows.Forms.Button btnEnviarCarro;
        private System.Windows.Forms.GroupBox gbProfesor;
        private System.Windows.Forms.Label lblAniosServicio;
        private System.Windows.Forms.TextBox txtAniosServicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.TextBox txtFinContrato;
        private System.Windows.Forms.Label lblDedicacion;
        private System.Windows.Forms.TextBox txtDedicacion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Button btnAceptarProfesor;
        private System.Windows.Forms.Button btnEliminarProfesor;
        private System.Windows.Forms.Button btnModificarProfesor;
        private System.Windows.Forms.Button btnListar;
    }
}

