namespace RetoSofka
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
            this.btnInicio = new System.Windows.Forms.Button();
            this.txtNomb = new System.Windows.Forms.TextBox();
            this.lblNomb = new System.Windows.Forms.Label();
            this.grpPregunta = new System.Windows.Forms.GroupBox();
            this.rdoRespuesta4 = new System.Windows.Forms.RadioButton();
            this.rdoRespuesta3 = new System.Windows.Forms.RadioButton();
            this.rdoRespuesta2 = new System.Windows.Forms.RadioButton();
            this.rdoRespuesta1 = new System.Windows.Forms.RadioButton();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.btnNex = new System.Windows.Forms.Button();
            this.txtPuntaje = new System.Windows.Forms.TextBox();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpOpcion = new System.Windows.Forms.GroupBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.grpPregunta.SuspendLayout();
            this.grpOpcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(1106, 209);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(298, 71);
            this.btnInicio.TabIndex = 5;
            this.btnInicio.Text = "Registrar Participante";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // txtNomb
            // 
            this.txtNomb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomb.Location = new System.Drawing.Point(533, 228);
            this.txtNomb.Name = "txtNomb";
            this.txtNomb.Size = new System.Drawing.Size(522, 32);
            this.txtNomb.TabIndex = 4;
            // 
            // lblNomb
            // 
            this.lblNomb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomb.AutoSize = true;
            this.lblNomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomb.Location = new System.Drawing.Point(253, 231);
            this.lblNomb.Name = "lblNomb";
            this.lblNomb.Size = new System.Drawing.Size(274, 29);
            this.lblNomb.TabIndex = 3;
            this.lblNomb.Text = "Nombre Participante : ";
            // 
            // grpPregunta
            // 
            this.grpPregunta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpPregunta.Controls.Add(this.rdoRespuesta4);
            this.grpPregunta.Controls.Add(this.rdoRespuesta3);
            this.grpPregunta.Controls.Add(this.rdoRespuesta2);
            this.grpPregunta.Controls.Add(this.rdoRespuesta1);
            this.grpPregunta.Controls.Add(this.lblPregunta);
            this.grpPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPregunta.Location = new System.Drawing.Point(101, 335);
            this.grpPregunta.Name = "grpPregunta";
            this.grpPregunta.Size = new System.Drawing.Size(1217, 370);
            this.grpPregunta.TabIndex = 6;
            this.grpPregunta.TabStop = false;
            this.grpPregunta.Text = "Pregunta";
            // 
            // rdoRespuesta4
            // 
            this.rdoRespuesta4.AutoSize = true;
            this.rdoRespuesta4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoRespuesta4.Location = new System.Drawing.Point(34, 278);
            this.rdoRespuesta4.Name = "rdoRespuesta4";
            this.rdoRespuesta4.Size = new System.Drawing.Size(174, 33);
            this.rdoRespuesta4.TabIndex = 4;
            this.rdoRespuesta4.Text = "radioButton4";
            this.rdoRespuesta4.UseVisualStyleBackColor = true;
            // 
            // rdoRespuesta3
            // 
            this.rdoRespuesta3.AutoSize = true;
            this.rdoRespuesta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoRespuesta3.Location = new System.Drawing.Point(33, 237);
            this.rdoRespuesta3.Name = "rdoRespuesta3";
            this.rdoRespuesta3.Size = new System.Drawing.Size(174, 33);
            this.rdoRespuesta3.TabIndex = 3;
            this.rdoRespuesta3.Text = "radioButton3";
            this.rdoRespuesta3.UseVisualStyleBackColor = true;
            // 
            // rdoRespuesta2
            // 
            this.rdoRespuesta2.AutoSize = true;
            this.rdoRespuesta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoRespuesta2.Location = new System.Drawing.Point(34, 195);
            this.rdoRespuesta2.Name = "rdoRespuesta2";
            this.rdoRespuesta2.Size = new System.Drawing.Size(174, 33);
            this.rdoRespuesta2.TabIndex = 2;
            this.rdoRespuesta2.Text = "radioButton2";
            this.rdoRespuesta2.UseVisualStyleBackColor = true;
            // 
            // rdoRespuesta1
            // 
            this.rdoRespuesta1.AutoSize = true;
            this.rdoRespuesta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoRespuesta1.Location = new System.Drawing.Point(34, 151);
            this.rdoRespuesta1.Name = "rdoRespuesta1";
            this.rdoRespuesta1.Size = new System.Drawing.Size(174, 33);
            this.rdoRespuesta1.TabIndex = 1;
            this.rdoRespuesta1.Text = "radioButton1";
            this.rdoRespuesta1.UseVisualStyleBackColor = true;
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(29, 87);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(79, 29);
            this.lblPregunta.TabIndex = 0;
            this.lblPregunta.Text = "label1";
            // 
            // btnNex
            // 
            this.btnNex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNex.Location = new System.Drawing.Point(23, 210);
            this.btnNex.Name = "btnNex";
            this.btnNex.Size = new System.Drawing.Size(223, 46);
            this.btnNex.TabIndex = 7;
            this.btnNex.Text = "Siguiente";
            this.btnNex.UseVisualStyleBackColor = true;
            this.btnNex.Click += new System.EventHandler(this.btnNex_Click);
            // 
            // txtPuntaje
            // 
            this.txtPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntaje.Location = new System.Drawing.Point(144, 65);
            this.txtPuntaje.Name = "txtPuntaje";
            this.txtPuntaje.Size = new System.Drawing.Size(100, 32);
            this.txtPuntaje.TabIndex = 6;
            this.txtPuntaje.Text = "0";
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntaje.Location = new System.Drawing.Point(25, 68);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(101, 29);
            this.lblPuntaje.TabIndex = 5;
            this.lblPuntaje.Text = "Puntaje";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(23, 266);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(221, 46);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grpOpcion
            // 
            this.grpOpcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpOpcion.Controls.Add(this.btnValidar);
            this.grpOpcion.Controls.Add(this.btnNex);
            this.grpOpcion.Controls.Add(this.txtPuntaje);
            this.grpOpcion.Controls.Add(this.lblPuntaje);
            this.grpOpcion.Controls.Add(this.btnSalir);
            this.grpOpcion.Location = new System.Drawing.Point(1335, 335);
            this.grpOpcion.Name = "grpOpcion";
            this.grpOpcion.Size = new System.Drawing.Size(272, 370);
            this.grpOpcion.TabIndex = 9;
            this.grpOpcion.TabStop = false;
            // 
            // btnValidar
            // 
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Location = new System.Drawing.Point(23, 154);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(223, 46);
            this.btnValidar.TabIndex = 9;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // picImagen
            // 
            this.picImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picImagen.ErrorImage = null;
            this.picImagen.Image = global::RetoSofka.Properties.Resources.sofkau_logo_horizontal;
            this.picImagen.InitialImage = null;
            this.picImagen.Location = new System.Drawing.Point(679, 40);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(331, 129);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagen.TabIndex = 10;
            this.picImagen.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1804, 789);
            this.Controls.Add(this.picImagen);
            this.Controls.Add(this.grpOpcion);
            this.Controls.Add(this.grpPregunta);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.txtNomb);
            this.Controls.Add(this.lblNomb);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reto Sofka";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPregunta.ResumeLayout(false);
            this.grpPregunta.PerformLayout();
            this.grpOpcion.ResumeLayout(false);
            this.grpOpcion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.TextBox txtNomb;
        private System.Windows.Forms.Label lblNomb;
        private System.Windows.Forms.GroupBox grpPregunta;
        private System.Windows.Forms.RadioButton rdoRespuesta4;
        private System.Windows.Forms.RadioButton rdoRespuesta3;
        private System.Windows.Forms.RadioButton rdoRespuesta2;
        private System.Windows.Forms.RadioButton rdoRespuesta1;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Button btnNex;
        private System.Windows.Forms.TextBox txtPuntaje;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grpOpcion;
        private System.Windows.Forms.Button btnValidar;
        internal System.Windows.Forms.PictureBox picImagen;
    }
}

