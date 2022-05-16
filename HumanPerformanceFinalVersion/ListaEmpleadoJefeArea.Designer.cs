namespace HumanPerformanceFinalVersion
{
    partial class ListaEmpleadoJefeArea
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
            this.listViewEmpleado = new System.Windows.Forms.ListView();
            this.clmNombre = new System.Windows.Forms.ColumnHeader();
            this.clmUsuario = new System.Windows.Forms.ColumnHeader();
            this.clmContrasena = new System.Windows.Forms.ColumnHeader();
            this.clmTipoUsuario = new System.Windows.Forms.ColumnHeader();
            this.clmCalificacionEmpleado = new System.Windows.Forms.ColumnHeader();
            this.btnRegresarJefeArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewEmpleado
            // 
            this.listViewEmpleado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNombre,
            this.clmUsuario,
            this.clmContrasena,
            this.clmTipoUsuario,
            this.clmCalificacionEmpleado});
            this.listViewEmpleado.Location = new System.Drawing.Point(67, 58);
            this.listViewEmpleado.Name = "listViewEmpleado";
            this.listViewEmpleado.Size = new System.Drawing.Size(482, 199);
            this.listViewEmpleado.TabIndex = 1;
            this.listViewEmpleado.UseCompatibleStateImageBehavior = false;
            this.listViewEmpleado.View = System.Windows.Forms.View.Details;
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
            this.clmCalificacionEmpleado.Width = 100;
            // 
            // btnRegresarJefeArea
            // 
            this.btnRegresarJefeArea.Location = new System.Drawing.Point(273, 277);
            this.btnRegresarJefeArea.Name = "btnRegresarJefeArea";
            this.btnRegresarJefeArea.Size = new System.Drawing.Size(75, 23);
            this.btnRegresarJefeArea.TabIndex = 3;
            this.btnRegresarJefeArea.Text = "Regresar";
            this.btnRegresarJefeArea.UseVisualStyleBackColor = true;
            this.btnRegresarJefeArea.Click += new System.EventHandler(this.btnRegresarJefeArea_Click);
            // 
            // ListaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresarJefeArea);
            this.Controls.Add(this.listViewEmpleado);
            this.Name = "ListaEmpleado";
            this.Text = "ListaEmpleado";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listViewEmpleado;
        private ColumnHeader clmNombre;
        private ColumnHeader clmUsuario;
        private ColumnHeader clmContrasena;
        private ColumnHeader clmTipoUsuario;
        private ColumnHeader clmCalificacionEmpleado;
        private Button btnRegresarJefeArea;
    }
}