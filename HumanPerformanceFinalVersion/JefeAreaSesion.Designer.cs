namespace HumanPerformanceFinalVersion
{
    partial class JefeAreaSesion
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
            this.lblJefeAreaSesion = new System.Windows.Forms.Label();
            this.txtJefeAreaUsuario = new System.Windows.Forms.TextBox();
            this.lblContraJefeAreaSesion = new System.Windows.Forms.Label();
            this.txtJefeAreaContrasena = new System.Windows.Forms.TextBox();
            this.btnJefeAreaIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJefeAreaSesion
            // 
            this.lblJefeAreaSesion.AutoSize = true;
            this.lblJefeAreaSesion.Location = new System.Drawing.Point(352, 88);
            this.lblJefeAreaSesion.Name = "lblJefeAreaSesion";
            this.lblJefeAreaSesion.Size = new System.Drawing.Size(47, 15);
            this.lblJefeAreaSesion.TabIndex = 1;
            this.lblJefeAreaSesion.Text = "Usuario";
            // 
            // txtJefeAreaUsuario
            // 
            this.txtJefeAreaUsuario.Location = new System.Drawing.Point(326, 122);
            this.txtJefeAreaUsuario.Name = "txtJefeAreaUsuario";
            this.txtJefeAreaUsuario.Size = new System.Drawing.Size(100, 23);
            this.txtJefeAreaUsuario.TabIndex = 2;
        
            // 
            // lblContraJefeAreaSesion
            // 
            this.lblContraJefeAreaSesion.AutoSize = true;
            this.lblContraJefeAreaSesion.Location = new System.Drawing.Point(341, 170);
            this.lblContraJefeAreaSesion.Name = "lblContraJefeAreaSesion";
            this.lblContraJefeAreaSesion.Size = new System.Drawing.Size(67, 15);
            this.lblContraJefeAreaSesion.TabIndex = 3;
            this.lblContraJefeAreaSesion.Text = "Contraseña";
            // 
            // txtJefeAreaContrasena
            // 
            this.txtJefeAreaContrasena.Location = new System.Drawing.Point(326, 206);
            this.txtJefeAreaContrasena.Name = "txtJefeAreaContrasena";
            this.txtJefeAreaContrasena.Size = new System.Drawing.Size(100, 23);
            this.txtJefeAreaContrasena.TabIndex = 4;
            // 
            // btnJefeAreaIngresar
            // 
            this.btnJefeAreaIngresar.Location = new System.Drawing.Point(341, 264);
            this.btnJefeAreaIngresar.Name = "btnJefeAreaIngresar";
            this.btnJefeAreaIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnJefeAreaIngresar.TabIndex = 5;
            this.btnJefeAreaIngresar.Text = "Ingresar";
            this.btnJefeAreaIngresar.UseVisualStyleBackColor = true;
            this.btnJefeAreaIngresar.Click += new System.EventHandler(this.btnJefeAreaIngresar_Click);
            // 
            // JefeAreaSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJefeAreaIngresar);
            this.Controls.Add(this.txtJefeAreaContrasena);
            this.Controls.Add(this.lblContraJefeAreaSesion);
            this.Controls.Add(this.txtJefeAreaUsuario);
            this.Controls.Add(this.lblJefeAreaSesion);
            this.Name = "JefeAreaSesion";
            this.Text = "JefeAreaSesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblJefeAreaSesion;
        private TextBox txtJefeAreaUsuario;
        private Label lblContraJefeAreaSesion;
        private TextBox txtJefeAreaContrasena;
        private Button btnJefeAreaIngresar;
    }
}