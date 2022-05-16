using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanPerformanceFinalVersion
{
    public partial class JefeAreaInicio : Form
    {
        List<string> nombre = new List<string>();
        List<string> usuario = new List<string>();
        List<string> contrasena = new List<string>();
        List<string> tipoUsuario = new List<string>();
        List<string> calificacion = new List<string>();
        public JefeAreaInicio(List<string> nom, List<string> usu, List<string> contra, List<string> Utip, List<string> califi)
        {
            InitializeComponent();
            nombre = nom;
            usuario = usu;
            contrasena = contra;
            tipoUsuario = Utip;
            calificacion = califi;
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            nombre.Add(txtNombreEmpleado.Text);
            usuario.Add(txtUsuarioEmpleado.Text);
            contrasena.Add(txtContrasenaEmpleado.Text);
            tipoUsuario.Add("Empleado");
            MessageBox.Show("El usuario agregado exitosamente");
        }

        private void btnVisualizarEmpleado_Click(object sender, EventArgs e)
        {
            ListaEmpleadoJefeArea listaJefeArea = new ListaEmpleadoJefeArea(nombre, usuario, contrasena, tipoUsuario, calificacion);
            listaJefeArea.Show();
            this.Hide();
        }

        private void btnCalificarEmpleado_Click(object sender, EventArgs e)
        {
            ListaEmpleadosCalificacion listaEmpleadosCalificacion = new ListaEmpleadosCalificacion(nombre, usuario, contrasena, tipoUsuario, calificacion);
            listaEmpleadosCalificacion.Show();
            this.Hide();
        }

        private void btnCerrarSesionJefeArea_Click(object sender, EventArgs e)
        {
            InicioSesion inicioSesion = new InicioSesion(nombre, usuario, contrasena, tipoUsuario, calificacion);
            inicioSesion.Show();
            this.Hide();
        }

       
    }
}
