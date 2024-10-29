namespace CapaVista
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los reCuota que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los reCuota administrados se deben desechar; false en caso contrario.</param>
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
            this.MostrarCV = new System.Windows.Forms.Button();
            this.Pantalla = new System.Windows.Forms.DataGridView();
            this.MostrarCuota = new System.Windows.Forms.Button();
            this.Asociado = new System.Windows.Forms.Button();
            this.MostrarAsistencia = new System.Windows.Forms.Button();
            this.Evento = new System.Windows.Forms.Button();
            this.Oferta = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.Pantalla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // MostrarCV
            // 
            this.MostrarCV.Location = new System.Drawing.Point(12, 12);
            this.MostrarCV.Name = "MostrarCV";
            this.MostrarCV.Size = new System.Drawing.Size(75, 23);
            this.MostrarCV.TabIndex = 0;
            this.MostrarCV.Text = "CV";
            this.MostrarCV.UseVisualStyleBackColor = true;
            this.MostrarCV.Click += new System.EventHandler(this.MostrarCV_Click);
            // 
            // Pantalla
            // 
            this.Pantalla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Pantalla.Location = new System.Drawing.Point(12, 56);
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.RowHeadersWidth = 51;
            this.Pantalla.RowTemplate.Height = 24;
            this.Pantalla.Size = new System.Drawing.Size(766, 324);
            this.Pantalla.TabIndex = 1;
            this.Pantalla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Pantalla_CellContentClick);
            // 
            // MostrarCuota
            // 
            this.MostrarCuota.Location = new System.Drawing.Point(169, 11);
            this.MostrarCuota.Name = "MostrarCuota";
            this.MostrarCuota.Size = new System.Drawing.Size(75, 23);
            this.MostrarCuota.TabIndex = 2;
            this.MostrarCuota.Text = " Cuotas";
            this.MostrarCuota.UseVisualStyleBackColor = true;
            this.MostrarCuota.Click += new System.EventHandler(this.MostrarCuotas_Click);
            // 
            // Asociado
            // 
            this.Asociado.Location = new System.Drawing.Point(291, 11);
            this.Asociado.Name = "Asociado";
            this.Asociado.Size = new System.Drawing.Size(115, 23);
            this.Asociado.TabIndex = 3;
            this.Asociado.Text = "Asociados";
            this.Asociado.UseVisualStyleBackColor = true;
            this.Asociado.Click += new System.EventHandler(this.Asociados_Click);
            // 
            // MostrarAsistencia
            // 
            this.MostrarAsistencia.Location = new System.Drawing.Point(453, 11);
            this.MostrarAsistencia.Name = "MostrarAsistencia";
            this.MostrarAsistencia.Size = new System.Drawing.Size(97, 23);
            this.MostrarAsistencia.TabIndex = 4;
            this.MostrarAsistencia.Text = "Asistencias";
            this.MostrarAsistencia.UseVisualStyleBackColor = true;
            this.MostrarAsistencia.Click += new System.EventHandler(this.MostrarAsistencias_Click);
            // 
            // Evento
            // 
            this.Evento.Location = new System.Drawing.Point(594, 11);
            this.Evento.Name = "Evento";
            this.Evento.Size = new System.Drawing.Size(75, 23);
            this.Evento.TabIndex = 5;
            this.Evento.Text = "Eventos";
            this.Evento.UseVisualStyleBackColor = true;
            this.Evento.Click += new System.EventHandler(this.Eventos_Click);
            // 
            // Oferta
            // 
            this.Oferta.Location = new System.Drawing.Point(703, 12);
            this.Oferta.Name = "Oferta";
            this.Oferta.Size = new System.Drawing.Size(75, 23);
            this.Oferta.TabIndex = 6;
            this.Oferta.Text = "Ofertas";
            this.Oferta.UseVisualStyleBackColor = true;
            this.Oferta.Click += new System.EventHandler(this.Ofertas_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            this.eventLog1.EntryWritten += new System.Diagnostics.EntryWrittenEventHandler(this.eventLog1_EntryWritten);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Oferta);
            this.Controls.Add(this.Evento);
            this.Controls.Add(this.MostrarAsistencia);
            this.Controls.Add(this.Asociado);
            this.Controls.Add(this.MostrarCuota);
            this.Controls.Add(this.Pantalla);
            this.Controls.Add(this.MostrarCV);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Pantalla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MostrarCV;
        private System.Windows.Forms.DataGridView Pantalla;
        private System.Windows.Forms.Button MostrarCuota;
        private System.Windows.Forms.Button Asociado;
        private System.Windows.Forms.Button MostrarAsistencia;
        private System.Windows.Forms.Button Evento;
        private System.Windows.Forms.Button Oferta;
        private System.Diagnostics.EventLog eventLog1;
    }
}

