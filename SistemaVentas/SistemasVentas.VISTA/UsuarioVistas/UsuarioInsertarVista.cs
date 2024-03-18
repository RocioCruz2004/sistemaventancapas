using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.PersonaVistas;

namespace SistemasVentas.VISTA.UsuarioVistas
{
    public partial class UsuarioInsertarVista : Form
    {
        public UsuarioInsertarVista()
        {
            InitializeComponent();
        }

        UsuarioBss bss = new UsuarioBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.IdPersona = Convert.ToInt32(textBox1.Text);
            u.NombreUser = textBox2.Text;
            u.Contraseña = textBox3.Text;
            u.FechaReg = dateTimePicker1.Value;

            bss.InsertarUsuarioBss(u);
            MessageBox.Show("Se guardo correctamente!");
        }
        public static int IdPersonaSeleccionada = 0; //variable global

        private void button3_Click(object sender, EventArgs e)
        {
            PersonaListarVista plv = new PersonaListarVista();
            /*plv.ShowDialog();*/
            if (plv.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
