namespace HumanPerformanceFinalVersion
{
    partial class InicioSesion
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
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnRecursosHumanos = new System.Windows.Forms.Button();
            this.btnJefeArea = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.lblIncioSesion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(71, 358);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(142, 23);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Administrador";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnRecursosHumanos
            // 
            this.btnRecursosHumanos.Location = new System.Drawing.Point(255, 358);
            this.btnRecursosHumanos.Name = "btnRecursosHumanos";
            this.btnRecursosHumanos.Size = new System.Drawing.Size(138, 23);
            this.btnRecursosHumanos.TabIndex = 2;
            this.btnRecursosHumanos.Text = "Recursos humanos";
            this.btnRecursosHumanos.UseVisualStyleBackColor = true;
            this.btnRecursosHumanos.Click += new System.EventHandler(this.btnRecursosHumanos_Click);
            // 
            // btnJefeArea
            // 
            this.btnJefeArea.Location = new System.Drawing.Point(435, 358);
            this.btnJefeArea.Name = "btnJefeArea";
            this.btnJefeArea.Size = new System.Drawing.Size(89, 23);
            this.btnJefeArea.TabIndex = 3;
            this.btnJefeArea.Text = "Jefe Área";
            this.btnJefeArea.UseVisualStyleBackColor = true;
            this.btnJefeArea.Click += new System.EventHandler(this.btnJefeArea_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Location = new System.Drawing.Point(572, 358);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnEmpleado.TabIndex = 4;
            this.btnEmpleado.Text = "Empleado";
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // lblIncioSesion
            // 
            this.lblIncioSesion.AutoSize = true;
            this.lblIncioSesion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIncioSesion.Location = new System.Drawing.Point(312, 56);
            this.lblIncioSesion.Name = "lblIncioSesion";
            this.lblIncioSesion.Size = new System.Drawing.Size(142, 25);
            this.lblIncioSesion.TabIndex = 5;
            this.lblIncioSesion.Text = "Inicio de sesión";
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIncioSesion);
            this.Controls.Add(this.btnEmpleado);
            this.Controls.Add(this.btnJefeArea);
            this.Controls.Add(this.btnRecursosHumanos);
            this.Controls.Add(this.btnAdmin);
            this.Name = "InicioSesion";
            this.Text = "InicioSesion";
            this.Load += new System.EventHandler(this.InicioSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAdmin;
        private Button btnRecursosHumanos;
        private Button btnJefeArea;
        private Button btnEmpleado;
        private Label lblIncioSesion;
    }
}