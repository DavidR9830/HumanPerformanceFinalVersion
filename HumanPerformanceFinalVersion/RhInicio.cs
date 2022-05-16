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
    public partial class RhInicio : Form
    {
        List<string> nombre = new List<string>();
        List<string> usuario = new List<string>();
        List<string> contrasena = new List<string>();
        List<string> tipoUsuario = new List<string>();
        List<string> calificacion = new List<string>();
        public RhInicio(List<string> nom, List<string> usu, List<string> contra, List<string> Utip, List<string> califi)
        {
            InitializeComponent();
            nombre = nom;
            usuario = usu;
            contrasena = contra;
            tipoUsuario = Utip;
            calificacion = califi;
        }

        private void btnAgregarJefeArea_Click(object sender, EventArgs e)
        {
            nombre.Add(txtNombreJefeArea.Text);
            usuario.Add(txtUsuarioJefeArea.Text);
            contrasena.Add(txtContrasenaJefeArea.Text);
            tipoUsuario.Add("Jefe de área");
            MessageBox.Show("El usuario agregado exitosamente");
        }

        private void btnVisualizarJefeArea_Click(object sender, EventArgs e)
        {
            ListaJefeArea listaJefeArea = new ListaJefeArea (nombre, usuario, contrasena, tipoUsuario, calificacion);
            listaJefeArea.Show();
            this.Hide();

        }

        private void btnCerrarSesionRh_Click(object sender, EventArgs e)
        {
            InicioSesion inicioSesion = new InicioSesion(nombre, usuario, contrasena, tipoUsuario, calificacion);
            inicioSesion.Show();
            this.Hide();
        }
    }
}
