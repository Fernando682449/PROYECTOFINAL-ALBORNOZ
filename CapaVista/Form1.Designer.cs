namespace CapaVista
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
            this.MostrarRoles = new System.Windows.Forms.Button();
            this.Pantalla = new System.Windows.Forms.DataGridView();
            this.MostrarCurso = new System.Windows.Forms.Button();
            this.Tareas = new System.Windows.Forms.Button();
            this.MostrarUsuarios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pantalla)).BeginInit();
            this.SuspendLayout();
            // 
            // MostrarRoles
            // 
            this.MostrarRoles.Location = new System.Drawing.Point(12, 12);
            this.MostrarRoles.Name = "MostrarRoles";
            this.MostrarRoles.Size = new System.Drawing.Size(75, 23);
            this.MostrarRoles.TabIndex = 0;
            this.MostrarRoles.Text = "Roles";
            this.MostrarRoles.UseVisualStyleBackColor = true;
            this.MostrarRoles.Click += new System.EventHandler(this.MostrarRoles_Click);
            // 
            // Pantalla
            // 
            this.Pantalla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Pantalla.Location = new System.Drawing.Point(12, 56);
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.RowHeadersWidth = 51;
            this.Pantalla.RowTemplate.Height = 24;
            this.Pantalla.Size = new System.Drawing.Size(766, 360);
            this.Pantalla.TabIndex = 1;
            this.Pantalla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Pantalla_CellContentClick);
            // 
            // MostrarCurso
            // 
            this.MostrarCurso.Location = new System.Drawing.Point(169, 11);
            this.MostrarCurso.Name = "MostrarCurso";
            this.MostrarCurso.Size = new System.Drawing.Size(75, 23);
            this.MostrarCurso.TabIndex = 2;
            this.MostrarCurso.Text = "Cursos";
            this.MostrarCurso.UseVisualStyleBackColor = true;
            this.MostrarCurso.Click += new System.EventHandler(this.MostrarCurso_Click);
            // 
            // Tareas
            // 
            this.Tareas.Location = new System.Drawing.Point(318, 11);
            this.Tareas.Name = "Tareas";
            this.Tareas.Size = new System.Drawing.Size(75, 23);
            this.Tareas.TabIndex = 3;
            this.Tareas.Text = "Tareas";
            this.Tareas.UseVisualStyleBackColor = true;
            this.Tareas.Click += new System.EventHandler(this.Tareas_Click);
            // 
            // MostrarUsuarios
            // 
            this.MostrarUsuarios.Location = new System.Drawing.Point(453, 11);
            this.MostrarUsuarios.Name = "MostrarUsuarios";
            this.MostrarUsuarios.Size = new System.Drawing.Size(75, 23);
            this.MostrarUsuarios.TabIndex = 4;
            this.MostrarUsuarios.Text = "Usuarios";
            this.MostrarUsuarios.UseVisualStyleBackColor = true;
            this.MostrarUsuarios.Click += new System.EventHandler(this.MostrarUsuarios_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MostrarUsuarios);
            this.Controls.Add(this.Tareas);
            this.Controls.Add(this.MostrarCurso);
            this.Controls.Add(this.Pantalla);
            this.Controls.Add(this.MostrarRoles);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Pantalla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MostrarRoles;
        private System.Windows.Forms.DataGridView Pantalla;
        private System.Windows.Forms.Button MostrarCurso;
        private System.Windows.Forms.Button Tareas;
        private System.Windows.Forms.Button MostrarUsuarios;
    }
}

