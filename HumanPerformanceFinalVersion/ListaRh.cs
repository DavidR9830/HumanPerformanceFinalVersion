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
    public partial class ListaRh : Form
    {
        List<string> nombre = new List<string>();
        List<string> usuario = new List<string>();
        List<string> contrasena = new List<string>();
        List<string> tipoUsuario = new List<string>();
        List<string> calificacion = new List<string>();
        public ListaRh(List<string>nom, List<string> usu, List<string> contra, List<string> Utip, List<string> califi)
        {
            InitializeComponent();
            nombre = nom;
            usuario = usu;
            contrasena = contra;
            tipoUsuario = Utip;
            calificacion = califi;
           
            for (int i = 0; i < nombre.Count; i++)
            {
                if (tipoUsuario[i] == "Recursos humanos")
                {
                    ListViewItem item = new ListViewItem();
                    item = listViewRh.Items.Add(nombre[i]);
                    item.SubItems.Add(usuario[i]);
                    item.SubItems.Add(contrasena[i]);
                    item.SubItems.Add(tipoUsuario[i]);
                }
            }
           
        }

       

        private void btnRegresarRh_Click(object sender, EventArgs e)
        {
            AdminInicio adminInicio = new AdminInicio(nombre,usuario,contrasena,tipoUsuario,calificacion);
            adminInicio.Show();
            this.Hide();
        }


        
    }
}
