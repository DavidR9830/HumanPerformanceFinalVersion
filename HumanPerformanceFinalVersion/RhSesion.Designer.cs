namespace HumanPerformanceFinalVersion
{
    partial class RhSesion
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
            this.lblRhSesion = new System.Windows.Forms.Label();
            this.txtRhUsuario = new System.Windows.Forms.TextBox();
            this.lblRhContrasena = new System.Windows.Forms.Label();
            this.txtRhContrasena = new System.Windows.Forms.TextBox();
            this.btnRhIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRhSesion
            // 
            this.lblRhSesion.AutoSize = true;
            this.lblRhSesion.Location = new System.Drawing.Point(284, 48);
            this.lblRhSesion.Name = "lblRhSesion";
            this.lblRhSesion.Size = new System.Drawing.Size(47, 15);
            this.lblRhSesion.TabIndex = 1;
            this.lblRhSesion.Text = "Usuario";
            // 
            // txtRhUsuario
            // 
            this.txtRhUsuario.Location = new System.Drawing.Point(264, 90);
            this.txtRhUsuario.Name = "txtRhUsuario";
            this.txtRhUsuario.Size = new System.Drawing.Size(100, 23);
            this.txtRhUsuario.TabIndex = 2;
            // 
            // lblRhContrasena
            // 
            this.lblRhContrasena.AutoSize = true;
            this.lblRhContrasena.Location = new System.Drawing.Point(274, 142);
            this.lblRhContrasena.Name = "lblRhContrasena";
            this.lblRhContrasena.Size = new System.Drawing.Size(67, 15);
            this.lblRhContrasena.TabIndex = 3;
            this.lblRhContrasena.Text = "Contraseña";
            // 
            // txtRhContrasena
            // 
            this.txtRhContrasena.Location = new System.Drawing.Point(264, 177);
            this.txtRhContrasena.Name = "txtRhContrasena";
            this.txtRhContrasena.Size = new System.Drawing.Size(100, 23);
            this.txtRhContrasena.TabIndex = 4;
            // 
            // btnRhIngresar
            // 
            this.btnRhIngresar.Location = new System.Drawing.Point(274, 241);
            this.btnRhIngresar.Name = "btnRhIngresar";
            this.btnRhIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnRhIngresar.TabIndex = 5;
            this.btnRhIngresar.Text = "Ingresar";
            this.btnRhIngresar.UseVisualStyleBackColor = true;
            this.btnRhIngresar.Click += new System.EventHandler(this.btnRhIngresar_Click);
            // 
            // RhSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRhIngresar);
            this.Controls.Add(this.txtRhContrasena);
            this.Controls.Add(this.lblRhContrasena);
            this.Controls.Add(this.txtRhUsuario);
            this.Controls.Add(this.lblRhSesion);
            this.Name = "RhSesion";
            this.Text = "RhSesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblRhSesion;
        private TextBox txtRhUsuario;
        private Label lblRhContrasena;
        private TextBox txtRhContrasena;
        private Button btnRhIngresar;
    }
}