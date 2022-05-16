namespace HumanPerformanceFinalVersion
{
    partial class AdminInicio
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
            this.btnAgregarRh = new System.Windows.Forms.Button();
            this.btnVisualizarRh = new System.Windows.Forms.Button();
            this.btnCerrarSesionAdmin = new System.Windows.Forms.Button();
            this.txtNombreRh = new System.Windows.Forms.TextBox();
            this.lblNombreRh = new System.Windows.Forms.Label();
            this.lblUsuarioRh = new System.Windows.Forms.Label();
            this.txtUsuarioRh = new System.Windows.Forms.TextBox();
            this.lblContrasenaRh = new System.Windows.Forms.Label();
            this.txtContrasenaRh = new System.Windows.Forms.TextBox();
            this.lblAdministrador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarRh
            // 
            this.btnAgregarRh.Location = new System.Drawing.Point(229, 283);
            this.btnAgregarRh.Name = "btnAgregarRh";
            this.btnAgregarRh.Size = new System.Drawing.Size(140, 57);
            this.btnAgregarRh.TabIndex = 0;
            this.btnAgregarRh.Text = "Registrar persona de recursos humanos";
            this.btnAgregarRh.UseVisualStyleBackColor = true;
            this.btnAgregarRh.Click += new System.EventHandler(this.btnAgregarRh_Click);
            // 
            // btnVisualizarRh
            // 
            this.btnVisualizarRh.Location = new System.Drawing.Point(437, 283);
            this.btnVisualizarRh.Name = "btnVisualizarRh";
            this.btnVisualizarRh.Size = new System.Drawing.Size(157, 57);
            this.btnVisualizarRh.TabIndex = 1;
            this.btnVisualizarRh.Text = "Visualizar lista de recursos humanos";
            this.btnVisualizarRh.UseVisualStyleBackColor = true;
            this.btnVisualizarRh.Click += new System.EventHandler(this.btnVisualizarRh_Click);
            // 
            // btnCerrarSesionAdmin
            // 
            this.btnCerrarSesionAdmin.Location = new System.Drawing.Point(348, 382);
            this.btnCerrarSesionAdmin.Name = "btnCerrarSesionAdmin";
            this.btnCerrarSesionAdmin.Size = new System.Drawing.Size(139, 23);
            this.btnCerrarSesionAdmin.TabIndex = 2;
            this.btnCerrarSesionAdmin.Text = "Cerrar Sesión";
            this.btnCerrarSesionAdmin.UseVisualStyleBackColor = true;
            this.btnCerrarSesionAdmin.Click += new System.EventHandler(this.btnCerrarSesionAdmin_Click);
            // 
            // txtNombreRh
            // 
            this.txtNombreRh.Location = new System.Drawing.Point(318, 97);
            this.txtNombreRh.Name = "txtNombreRh";
            this.txtNombreRh.Size = new System.Drawing.Size(169, 23);
            this.txtNombreRh.TabIndex = 3;
            // 
            // lblNombreRh
            // 
            this.lblNombreRh.AutoSize = true;
            this.lblNombreRh.Location = new System.Drawing.Point(351, 70);
            this.lblNombreRh.Name = "lblNombreRh";
            this.lblNombreRh.Size = new System.Drawing.Size(90, 15);
            this.lblNombreRh.TabIndex = 4;
            this.lblNombreRh.Text = "Ingrese nombre";
            // 
            // lblUsuarioRh
            // 
            this.lblUsuarioRh.AutoSize = true;
            this.lblUsuarioRh.Location = new System.Drawing.Point(351, 123);
            this.lblUsuarioRh.Name = "lblUsuarioRh";
            this.lblUsuarioRh.Size = new System.Drawing.Size(87, 15);
            this.lblUsuarioRh.TabIndex = 5;
            this.lblUsuarioRh.Text = "Ingrese usuario";
            // 
            // txtUsuarioRh
            // 
            this.txtUsuarioRh.Location = new System.Drawing.Point(339, 150);
            this.txtUsuarioRh.Name = "txtUsuarioRh";
            this.txtUsuarioRh.Size = new System.Drawing.Size(126, 23);
            this.txtUsuarioRh.TabIndex = 6;
            // 
            // lblContrasenaRh
            // 
            this.lblContrasenaRh.AutoSize = true;
            this.lblContrasenaRh.Location = new System.Drawing.Point(348, 186);
            this.lblContrasenaRh.Name = "lblContrasenaRh";
            this.lblContrasenaRh.Size = new System.Drawing.Size(106, 15);
            this.lblContrasenaRh.TabIndex = 7;
            this.lblContrasenaRh.Text = "Ingrese contraseña";
            // 
            // txtContrasenaRh
            // 
            this.txtContrasenaRh.Location = new System.Drawing.Point(351, 214);
            this.txtContrasenaRh.Name = "txtContrasenaRh";
            this.txtContrasenaRh.Size = new System.Drawing.Size(100, 23);
            this.txtContrasenaRh.TabIndex = 8;
            // 
            // lblAdministrador
            // 
            this.lblAdministrador.AutoSize = true;
            this.lblAdministrador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdministrador.Location = new System.Drawing.Point(344, 21);
            this.lblAdministrador.Name = "lblAdministrador";
            this.lblAdministrador.Size = new System.Drawing.Size(110, 21);
            this.lblAdministrador.TabIndex = 9;
            this.lblAdministrador.Text = "Administrador";
            // 
            // AdminInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAdministrador);
            this.Controls.Add(this.txtContrasenaRh);
            this.Controls.Add(this.lblContrasenaRh);
            this.Controls.Add(this.txtUsuarioRh);
            this.Controls.Add(this.lblUsuarioRh);
            this.Controls.Add(this.lblNombreRh);
            this.Controls.Add(this.txtNombreRh);
            this.Controls.Add(this.btnCerrarSesionAdmin);
            this.Controls.Add(this.btnVisualizarRh);
            this.Controls.Add(this.btnAgregarRh);
            this.Name = "AdminInicio";
            this.Text = "AdminInicio";
            this.Load += new System.EventHandler(this.AdminInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAgregarRh;
        private Button btnVisualizarRh;
        private Button btnCerrarSesionAdmin;
        private TextBox txtNombreRh;
        private Label lblNombreRh;
        private Label lblUsuarioRh;
        private TextBox txtUsuarioRh;
        private Label lblContrasenaRh;
        private TextBox txtContrasenaRh;
        private Label lblAdministrador;
    }
}