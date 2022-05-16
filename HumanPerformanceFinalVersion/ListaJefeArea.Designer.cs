namespace HumanPerformanceFinalVersion
{
    partial class ListaJefeArea
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
            this.listViewJefeArea = new System.Windows.Forms.ListView();
            this.clmNombre = new System.Windows.Forms.ColumnHeader();
            this.clmUsuario = new System.Windows.Forms.ColumnHeader();
            this.clmContrasena = new System.Windows.Forms.ColumnHeader();
            this.clmTipoUsuario = new System.Windows.Forms.ColumnHeader();
            this.clmCalificacionEmpleado = new System.Windows.Forms.ColumnHeader();
            this.btnRegresarJefeArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewJefeArea
            // 
            this.listViewJefeArea.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNombre,
            this.clmUsuario,
            this.clmContrasena,
            this.clmTipoUsuario,
            this.clmCalificacionEmpleado});
            this.listViewJefeArea.Location = new System.Drawing.Point(75, 51);
            this.listViewJefeArea.Name = "listViewJefeArea";
            this.listViewJefeArea.Size = new System.Drawing.Size(406, 259);
            this.listViewJefeArea.TabIndex = 1;
            this.listViewJefeArea.UseCompatibleStateImageBehavior = false;
            this.listViewJefeArea.View = System.Windows.Forms.View.Details;
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
            // btnRegresarJefeArea
            // 
            this.btnRegresarJefeArea.Location = new System.Drawing.Point(249, 334);
            this.btnRegresarJefeArea.Name = "btnRegresarJefeArea";
            this.btnRegresarJefeArea.Size = new System.Drawing.Size(75, 23);
            this.btnRegresarJefeArea.TabIndex = 2;
            this.btnRegresarJefeArea.Text = "Regresar";
            this.btnRegresarJefeArea.UseVisualStyleBackColor = true;
            this.btnRegresarJefeArea.Click += new System.EventHandler(this.btnRegresarJefeArea_Click);
            // 
            // ListaJefeArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresarJefeArea);
            this.Controls.Add(this.listViewJefeArea);
            this.Name = "ListaJefeArea";
            this.Text = "ListaJefeArea";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listViewJefeArea;
        private ColumnHeader clmNombre;
        private ColumnHeader clmUsuario;
        private ColumnHeader clmContrasena;
        private ColumnHeader clmTipoUsuario;
        private ColumnHeader clmCalificacionEmpleado;
        private Button btnRegresarJefeArea;
    }
}