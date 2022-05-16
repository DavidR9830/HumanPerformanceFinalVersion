namespace HumanPerformanceFinalVersion
{
    partial class AdminSesion
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
            this.lblAdminSesion = new System.Windows.Forms.Label();
            this.txtUsarioAdminSesion = new System.Windows.Forms.TextBox();
            this.lblContraAdminSesion = new System.Windows.Forms.Label();
            this.txtAdminContraSesion = new System.Windows.Forms.TextBox();
            this.btnAdminIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdminSesion
            // 
            this.lblAdminSesion.AutoSize = true;
            this.lblAdminSesion.Location = new System.Drawing.Point(344, 61);
            this.lblAdminSesion.Name = "lblAdminSesion";
            this.lblAdminSesion.Size = new System.Drawing.Size(47, 15);
            this.lblAdminSesion.TabIndex = 0;
            this.lblAdminSesion.Text = "Usuario";
            // 
            // txtUsarioAdminSesion
            // 
            this.txtUsarioAdminSesion.Location = new System.Drawing.Point(328, 94);
            this.txtUsarioAdminSesion.Name = "txtUsarioAdminSesion";
            this.txtUsarioAdminSesion.Size = new System.Drawing.Size(100, 23);
            this.txtUsarioAdminSesion.TabIndex = 1;
            // 
            // lblContraAdminSesion
            // 
            this.lblContraAdminSesion.AutoSize = true;
            this.lblContraAdminSesion.Location = new System.Drawing.Point(344, 140);
            this.lblContraAdminSesion.Name = "lblContraAdminSesion";
            this.lblContraAdminSesion.Size = new System.Drawing.Size(67, 15);
            this.lblContraAdminSesion.TabIndex = 2;
            this.lblContraAdminSesion.Text = "Contraseña";
            // 
            // txtAdminContraSesion
            // 
            this.txtAdminContraSesion.Location = new System.Drawing.Point(328, 182);
            this.txtAdminContraSesion.Name = "txtAdminContraSesion";
            this.txtAdminContraSesion.Size = new System.Drawing.Size(100, 23);
            this.txtAdminContraSesion.TabIndex = 3;
            // 
            // btnAdminIngresar
            // 
            this.btnAdminIngresar.Location = new System.Drawing.Point(344, 246);
            this.btnAdminIngresar.Name = "btnAdminIngresar";
            this.btnAdminIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnAdminIngresar.TabIndex = 4;
            this.btnAdminIngresar.Text = "Ingresar";
            this.btnAdminIngresar.UseVisualStyleBackColor = true;
            this.btnAdminIngresar.Click += new System.EventHandler(this.btnAdminIngresar_Click);
            // 
            // AdminSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdminIngresar);
            this.Controls.Add(this.txtAdminContraSesion);
            this.Controls.Add(this.lblContraAdminSesion);
            this.Controls.Add(this.txtUsarioAdminSesion);
            this.Controls.Add(this.lblAdminSesion);
            this.Name = "AdminSesion";
            this.Text = "AdminSesion";
            this.Load += new System.EventHandler(this.Ad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAdminSesion;
        private TextBox txtUsarioAdminSesion;
        private Label lblContraAdminSesion;
        private TextBox txtAdminContraSesion;
        private Button btnAdminIngresar;
    }
}