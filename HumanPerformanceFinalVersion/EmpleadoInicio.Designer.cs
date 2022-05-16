namespace HumanPerformanceFinalVersion
{
    partial class EmpleadoInicio
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
            this.btnVisualizarCalificacion = new System.Windows.Forms.Button();
            this.btnCerrarSesionEmpleado = new System.Windows.Forms.Button();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVisualizarCalificacion
            // 
            this.btnVisualizarCalificacion.AllowDrop = true;
            this.btnVisualizarCalificacion.Location = new System.Drawing.Point(319, 168);
            this.btnVisualizarCalificacion.Name = "btnVisualizarCalificacion";
            this.btnVisualizarCalificacion.Size = new System.Drawing.Size(163, 57);
            this.btnVisualizarCalificacion.TabIndex = 14;
            this.btnVisualizarCalificacion.Text = "Visualizar mi calificación";
            this.btnVisualizarCalificacion.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesionEmpleado
            // 
            this.btnCerrarSesionEmpleado.Location = new System.Drawing.Point(330, 267);
            this.btnCerrarSesionEmpleado.Name = "btnCerrarSesionEmpleado";
            this.btnCerrarSesionEmpleado.Size = new System.Drawing.Size(139, 23);
            this.btnCerrarSesionEmpleado.TabIndex = 15;
            this.btnCerrarSesionEmpleado.Text = "Cerrar Sesión";
            this.btnCerrarSesionEmpleado.UseVisualStyleBackColor = true;
            this.btnCerrarSesionEmpleado.Click += new System.EventHandler(this.btnCerrarSesionEmpleado_Click);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmpleado.Location = new System.Drawing.Point(357, 70);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(79, 21);
            this.lblEmpleado.TabIndex = 16;
            this.lblEmpleado.Text = "Empleado";
            // 
            // EmpleadoInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.btnCerrarSesionEmpleado);
            this.Controls.Add(this.btnVisualizarCalificacion);
            this.Name = "EmpleadoInicio";
            this.Text = "EmpleadoInicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnVisualizarCalificacion;
        private Button btnCerrarSesionEmpleado;
        private Label lblEmpleado;
    }
}