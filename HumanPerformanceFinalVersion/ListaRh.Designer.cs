namespace HumanPerformanceFinalVersion
{
    partial class ListaRh
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
            this.listViewRh = new System.Windows.Forms.ListView();
            this.clmNombre = new System.Windows.Forms.ColumnHeader();
            this.clmUsuario = new System.Windows.Forms.ColumnHeader();
            this.clmContrasena = new System.Windows.Forms.ColumnHeader();
            this.clmTipoUsuario = new System.Windows.Forms.ColumnHeader();
            this.clmCalificacionEmpleado = new System.Windows.Forms.ColumnHeader();
            this.btnRegresarRh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewRh
            // 
            this.listViewRh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNombre,
            this.clmUsuario,
            this.clmContrasena,
            this.clmTipoUsuario,
            this.clmCalificacionEmpleado});
            this.listViewRh.Location = new System.Drawing.Point(85, 82);
            this.listViewRh.Name = "listViewRh";
            this.listViewRh.Size = new System.Drawing.Size(407, 199);
            this.listViewRh.TabIndex = 0;
            this.listViewRh.UseCompatibleStateImageBehavior = false;
            this.listViewRh.View = System.Windows.Forms.View.Details;
       
            // 
            // clmNombre
            // 
            this.clmNombre.Text = "Nombre";
            this.clmNombre.Width = 100;
            // 
            // clmUsuario
            // 
            this.clmUsuario.Text = "Usuario";
            this.clmUsuario.Width = 100;
            // 
            // clmContrasena
            // 
            this.clmContrasena.Text = "Contraseña";
            this.clmContrasena.Width = 100;
            // 
            // clmTipoUsuario
            // 
            this.clmTipoUsuario.Text = "Tipo Usuario";
            this.clmTipoUsuario.Width = 100;
            // 
            // clmCalificacionEmpleado
            // 
            this.clmCalificacionEmpleado.Text = "Calificación";
            this.clmCalificacionEmpleado.Width = 0;
            // 
            // btnRegresarRh
            // 
            this.btnRegresarRh.Location = new System.Drawing.Point(249, 322);
            this.btnRegresarRh.Name = "btnRegresarRh";
            this.btnRegresarRh.Size = new System.Drawing.Size(75, 23);
            this.btnRegresarRh.TabIndex = 1;
            this.btnRegresarRh.Text = "Regresar";
            this.btnRegresarRh.UseVisualStyleBackColor = true;
            this.btnRegresarRh.Click += new System.EventHandler(this.btnRegresarRh_Click);
            // 
            // ListaRh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresarRh);
            this.Controls.Add(this.listViewRh);
            this.Name = "ListaRh";
            this.Text = "AdminListaRh";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listViewRh;
        private ColumnHeader clmNombre;
        private ColumnHeader clmUsuario;
        private ColumnHeader clmContrasena;
        private ColumnHeader clmTipoUsuario;
        private Button btnRegresarRh;
        private ColumnHeader clmCalificacionEmpleado;
    }
}