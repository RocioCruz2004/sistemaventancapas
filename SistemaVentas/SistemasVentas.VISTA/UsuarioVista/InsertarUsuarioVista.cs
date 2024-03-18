using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.PersonaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.UsuarioVista
{
    public partial class InsertarUsuarioVista : Form
    {
        public InsertarUsuarioVista()
        {
            InitializeComponent();
        }
        public static int IdPersonaSeleccionada = 0; //variable local
        PersonaBss bss = new PersonaBss();
        private void button3_Click(object sender, EventArgs e)
        {
            PersonaListarVista plv = new PersonaListarVista();
            /*plv.showDialog();*/
            if(plv.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bss.ObtenerIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
 
            }
        }
    }
}
