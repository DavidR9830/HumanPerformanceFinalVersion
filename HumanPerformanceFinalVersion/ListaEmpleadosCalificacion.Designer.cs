namespace HumanPerformanceFinalVersion
{
    partial class ListaEmpleadosCalificacion
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
            this.listViewEmpleadoCalificar = new System.Windows.Forms.ListView();
            this.clmNombre = new System.Windows.Forms.ColumnHeader();
            this.clmUsuario = new System.Windows.Forms.ColumnHeader();
            this.clmContrasena = new System.Windows.Forms.ColumnHeader();
            this.clmTipoUsuario = new System.Windows.Forms.ColumnHeader();
            this.clmCalificacionEmpleado = new System.Windows.Forms.ColumnHeader();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.txtBuscarEmpleado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listViewEmpleadoCalificar
            // 
            this.listViewEmpleadoCalificar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNombre,
            this.clmUsuario,
            this.clmContrasena,
            this.clmTipoUsuario,
            this.clmCalificacionEmpleado});
            this.listViewEmpleadoCalificar.Location = new System.Drawing.Point(40, 54);
            this.listViewEmpleadoCalificar.Name = "listViewEmpleadoCalificar";
            this.listViewEmpleadoCalificar.Size = new System.Drawing.Size(482, 199);
            this.listViewEmpleadoCalificar.TabIndex = 2;
            this.listViewEmpleadoCalificar.UseCompatibleStateImageBehavior = false;
            this.listViewEmpleadoCalificar.View = System.Windows.Forms.View.Details;
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
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(135, 370);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(143, 23);
            this.btnBuscarEmpleado.TabIndex = 3;
            this.btnBuscarEmpleado.Text = "Buscar empleado";
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // txtBuscarEmpleado
            // 
            this.txtBuscarEmpleado.Location = new System.Drawing.Point(153, 326);
            this.txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            this.txtBuscarEmpleado.Size = new System.Drawing.Size(100, 23);
            this.txtBuscarEmpleado.TabIndex = 4;
            // 
            // ListaEmpleadosCalificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBuscarEmpleado);
            this.Controls.Add(this.btnBuscarEmpleado);
            this.Controls.Add(this.listViewEmpleadoCalificar);
            this.Name = "ListaEmpleadosCalificacion";
            this.Text = "ListaEmpleadosCalificacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listViewEmpleadoCalificar;
        private ColumnHeader clmNombre;
        private ColumnHeader clmUsuario;
        private ColumnHeader clmContrasena;
        private ColumnHeader clmTipoUsuario;
        private ColumnHeader clmCalificacionEmpleado;
        private Button btnBuscarEmpleado;
        private TextBox txtBuscarEmpleado;
    }
}