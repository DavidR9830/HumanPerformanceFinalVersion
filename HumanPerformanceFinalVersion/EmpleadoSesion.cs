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
    public partial class EmpleadoSesion : Form
    {
        List<string> nombre = new List<string>();
        List<string> usuario = new List<string>();
        List<string> contrasena = new List<string>();
        List<string> tipoUsuario = new List<string>();
        List<string> calificacion = new List<string>();
        public EmpleadoSesion(List<string> nom, List<string> usu, List<string> contra, List<string> Utip, List<string> califi)
        {
            InitializeComponent();
            nombre = nom;
            usuario = usu;
            contrasena = contra;
            tipoUsuario = Utip;
            calificacion = califi;
        }

        private void btnEmpleadoIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                int iusu = usuario.IndexOf(txtEmpleadoUsuario.Text);
                int ipass = contrasena.IndexOf(txtEmpleadoContrasena.Text);

                if (iusu != ipass)
                {
                    MessageBox.Show("Usuario o contraseña incorrecto");
                }
                else if (txtEmpleadoUsuario.Text == usuario[iusu] && txtEmpleadoContrasena.Text == contrasena[ipass])
                {
                    if (tipoUsuario[iusu] == "Empleado")
                    {
                        MessageBox.Show("¡Credenciales correctas, bienvenido!");
                        EmpleadoInicio Empleado_Inicio = new EmpleadoInicio(nombre, usuario, contrasena, tipoUsuario, calificacion);
                        Empleado_Inicio.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("El usuario no es un empleado");
                    }
                    if (iusu == -1 || ipass == -1)
                    {
                        MessageBox.Show("Usuario o contraseña incorrecto");

                    }

                }

            }
            catch (Exception)
            {
                MessageBox.Show("El usuario o la contraseña no corresponden " +
                    " al campo de texto donde se ingresaron ");
            }
        }
    }
    
}
