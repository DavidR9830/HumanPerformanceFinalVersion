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
    public partial class AdminInicio : Form
    {
        List<string> nombre = new List<string>();
        List<string> usuario = new List<string>();
        List<string> contrasena = new List<string>();
        List<string> tipoUsuario = new List<string>();
        List<string> calificacion = new List<string>();
        public AdminInicio(List<string> nom, List<string> usu, List<string> contra, List<string> Utip, List<string> califi)
        {
            InitializeComponent();
            nombre = nom;
            usuario = usu;
            contrasena = contra;
            tipoUsuario = Utip;
            calificacion = califi;
            
        }

        private void AdminInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarRh_Click(object sender, EventArgs e)
        {
            nombre.Add(txtNombreRh.Text);
            usuario.Add(txtUsuarioRh.Text);
            contrasena.Add(txtContrasenaRh.Text);         
            tipoUsuario.Add("Recursos humanos");
            MessageBox.Show("El usuario agregado exitosamente");
        }

        private void btnVisualizarRh_Click(object sender, EventArgs e)
        {
            ListaRh listaUsuarios = new ListaRh(nombre,usuario,contrasena,tipoUsuario,calificacion);
            listaUsuarios.Show();
            this.Hide();
        }

        private void btnCerrarSesionAdmin_Click(object sender, EventArgs e)
        {
            InicioSesion inicioSesion = new InicioSesion(nombre, usuario, contrasena, tipoUsuario, calificacion);
            inicioSesion.Show();
            this.Hide();
        }
    }
}
