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
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblPotencia = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtPotenciaCaballos = new System.Windows.Forms.TextBox();
            this.lblNumeroPlazas = new System.Windows.Forms.Label();
            this.lblNumeroLicencia = new System.Windows.Forms.Label();
            this.txtNumeroLicencia = new System.Windows.Forms.TextBox();
            this.txtNumeroPlazas = new System.Windows.Forms.TextBox();
            this.btnEnviarCarro = new System.Windows.Forms.Button();
            this.gbCarro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCarro
            // 
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
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(6, 32);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(57, 13);
            this.lblMatricula.TabIndex = 6;
            this.lblMatricula.Text = "*Matricula:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(98, 32);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 1;
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
            // lblNumeroPlazas
            // 
            this.lblNumeroPlazas.AutoSize = true;
            this.lblNumeroPlazas.Location = new System.Drawing.Point(243, 65);
            this.lblNumeroPlazas.Name = "lblNumeroPlazas";
            this.lblNumeroPlazas.Size = new System.Drawing.Size(95, 13);
            this.lblNumeroPlazas.TabIndex = 14;
            this.lblNumeroPlazas.Text = "Número de plazas:";
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
            // txtNumeroPlazas
            // 
            this.txtNumeroPlazas.Location = new System.Drawing.Point(344, 62);
            this.txtNumeroPlazas.Name = "txtNumeroPlazas";
            this.txtNumeroPlazas.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroPlazas.TabIndex = 12;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 409);
            this.Controls.Add(this.gbCarro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbCarro.ResumeLayout(false);
            this.gbCarro.PerformLayout();
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
    }
}

