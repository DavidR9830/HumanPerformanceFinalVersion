namespace HumanPerformanceFinalVersion
{
    partial class EmpleadoSesion
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
            this.lblEmpleadoSesion = new System.Windows.Forms.Label();
            this.txtEmpleadoUsuario = new System.Windows.Forms.TextBox();
            this.lblContraEmpleadoSesion = new System.Windows.Forms.Label();
            this.txtEmpleadoContrasena = new System.Windows.Forms.TextBox();
            this.btnEmpleadoIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmpleadoSesion
            // 
            this.lblEmpleadoSesion.AutoSize = true;
            this.lblEmpleadoSesion.Location = new System.Drawing.Point(364, 85);
            this.lblEmpleadoSesion.Name = "lblEmpleadoSesion";
            this.lblEmpleadoSesion.Size = new System.Drawing.Size(47, 15);
            this.lblEmpleadoSesion.TabIndex = 2;
            this.lblEmpleadoSesion.Text = "Usuario";
            // 
            // txtEmpleadoUsuario
            // 
            this.txtEmpleadoUsuario.Location = new System.Drawing.Point(341, 116);
            this.txtEmpleadoUsuario.Name = "txtEmpleadoUsuario";
            this.txtEmpleadoUsuario.Size = new System.Drawing.Size(100, 23);
            this.txtEmpleadoUsuario.TabIndex = 3;
            // 
            // lblContraEmpleadoSesion
            // 
            this.lblContraEmpleadoSesion.AutoSize = true;
            this.lblContraEmpleadoSesion.Location = new System.Drawing.Point(353, 168);
            this.lblContraEmpleadoSesion.Name = "lblContraEmpleadoSesion";
            this.lblContraEmpleadoSesion.Size = new System.Drawing.Size(67, 15);
            this.lblContraEmpleadoSesion.TabIndex = 4;
            this.lblContraEmpleadoSesion.Text = "Contraseña";
            // 
            // txtEmpleadoContrasena
            // 
            this.txtEmpleadoContrasena.Location = new System.Drawing.Point(341, 198);
            this.txtEmpleadoContrasena.Name = "txtEmpleadoContrasena";
            this.txtEmpleadoContrasena.Size = new System.Drawing.Size(100, 23);
            this.txtEmpleadoContrasena.TabIndex = 5;
            // 
            // btnEmpleadoIngresar
            // 
            this.btnEmpleadoIngresar.Location = new System.Drawing.Point(353, 256);
            this.btnEmpleadoIngresar.Name = "btnEmpleadoIngresar";
            this.btnEmpleadoIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnEmpleadoIngresar.TabIndex = 6;
            this.btnEmpleadoIngresar.Text = "Ingresar";
            this.btnEmpleadoIngresar.UseVisualStyleBackColor = true;
            this.btnEmpleadoIngresar.Click += new System.EventHandler(this.btnEmpleadoIngresar_Click);
            // 
            // EmpleadoSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEmpleadoIngresar);
            this.Controls.Add(this.txtEmpleadoContrasena);
            this.Controls.Add(this.lblContraEmpleadoSesion);
            this.Controls.Add(this.txtEmpleadoUsuario);
            this.Controls.Add(this.lblEmpleadoSesion);
            this.Name = "EmpleadoSesion";
            this.Text = "EmpleadoSesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEmpleadoSesion;
        private TextBox txtEmpleadoUsuario;
        private Label lblContraEmpleadoSesion;
        private TextBox txtEmpleadoContrasena;
        private Button btnEmpleadoIngresar;
    }
}