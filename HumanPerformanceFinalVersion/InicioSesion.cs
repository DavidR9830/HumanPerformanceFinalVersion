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
    public partial class InicioSesion : Form
    {
        List<string> nombre = new List<string>();
        List<string> usuario = new List<string>();
        List<string> contrasena = new List<string>();
        List<string> tipoUsuario = new List<string>();
        List<string> calificacion = new List<string>();
        public InicioSesion(List<string> nom, List<string> usu, List<string> contra, List<string> Utip, List<string> califi)
        {
            nombre = nom;
            usuario = usu;
            contrasena = contra;
            tipoUsuario = Utip;
            calificacion = califi;
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
           AdminSesion adminSesion = new AdminSesion(nombre,usuario,contrasena,tipoUsuario,calificacion);
            adminSesion.Show();
            this.Hide();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void btnRecursosHumanos_Click(object sender, EventArgs e)
        {
            RhSesion rhSesion = new RhSesion(nombre, usuario, contrasena, tipoUsuario, calificacion);
            rhSesion.Show();
            this.Hide();
        }

        private void btnJefeArea_Click(object sender, EventArgs e)
        {
            JefeAreaSesion jefeAreaSesion  = new JefeAreaSesion(nombre, usuario, contrasena, tipoUsuario, calificacion);
            jefeAreaSesion.Show();
            this.Hide();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            EmpleadoSesion EmpleadoSesion = new EmpleadoSesion(nombre, usuario, contrasena, tipoUsuario, calificacion);
            EmpleadoSesion.Show();
            this.Hide();
        }
    }
}
