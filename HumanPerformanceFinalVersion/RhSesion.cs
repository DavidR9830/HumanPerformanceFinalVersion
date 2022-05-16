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
    public partial class RhSesion : Form
    {
        List<string> nombre = new List<string>();
        List<string> usuario = new List<string>();
        List<string> contrasena = new List<string>();
        List<string> tipoUsuario = new List<string>();
        List<string> calificacion = new List<string>();
        public RhSesion(List<string> nom, List<string> usu, List<string> contra, List<string> Utip, List<string> califi)
        {
            InitializeComponent();
            nombre = nom;
            usuario = usu;
            contrasena = contra;
            tipoUsuario = Utip;
            calificacion = califi;
        }

        private void btnRhIngresar_Click(object sender, EventArgs e)
        {
            try 
            {
                int iusu = usuario.IndexOf(txtRhUsuario.Text);
                int ipass = contrasena.IndexOf(txtRhContrasena.Text);

                if (iusu != ipass)
                {
                    MessageBox.Show("Usuario o contraseña incorrecto");
                }
                else if (txtRhUsuario.Text == usuario[iusu] && txtRhContrasena.Text == contrasena[ipass])
                {
                    if (tipoUsuario[iusu] == "Recursos humanos")
                    {
                        MessageBox.Show("¡Credenciales correctas, bienvenido!");
                        RhInicio rhInicio = new RhInicio(nombre,usuario,contrasena,tipoUsuario,calificacion);
                        rhInicio.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("El usuario no es de recursos humanos");
                    }
                     if (iusu == -1 || ipass == -1)
                    {
                        MessageBox.Show("Usuario o contraseña incorrecto");

                    }

                }

            } catch (Exception)
            { 
             MessageBox.Show("El usuario o la contraseña no corresponden " +
                 " al campo de texto donde se ingresaron "); 
            }
            

        }
    

    
    }
}
