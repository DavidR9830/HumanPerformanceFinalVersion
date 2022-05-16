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
    public partial class AdminSesion : Form
    {
        List<string> nombre = new List<string>();
        List<string> usuario = new List<string>();
        List<string> contrasena = new List<string>();
        List<string> tipoUsuario = new List<string>();
        List<string> calificacion = new List<string>();
        public AdminSesion(List<string> nom, List<string> usu, List<string> contra, List<string> Utip, List<string> califi)
        {
            InitializeComponent();
            nombre = nom;
            usuario = usu;
            contrasena = contra;
            tipoUsuario = Utip;
            calificacion = califi;
        }

        private void Ad_Load(object sender, EventArgs e)
        {

        }

        private void btnAdminIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsarioAdminSesion.Text == "Admin" && txtAdminContraSesion.Text == "0000")
            {
                MessageBox.Show("¡Credenciales correctas, bienvenido!");
                AdminInicio adminInicio = new AdminInicio(nombre,usuario,contrasena,tipoUsuario,calificacion);
                adminInicio.Show();
                this.Hide();
            }
            else if (txtUsarioAdminSesion.Text == "" || txtAdminContraSesion.Text == "")
            {
                MessageBox.Show("Llene por favor todos los campos");
            }
            else if (txtUsarioAdminSesion.Text != "Admin" || txtAdminContraSesion.Text != "0000")
            {
                MessageBox.Show("Usuario o contraseña incorrecto");
            }
        }
    }
}
