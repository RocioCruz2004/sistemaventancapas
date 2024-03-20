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

namespace SistemasVentas.VISTA.UsuarioVistas
{
    public partial class EditarUsuarioVista : Form
    {
        Usuario u = new Usuario();
        UsuarioBss bss = new UsuarioBss();
        int idx = 0;
        public EditarUsuarioVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void EditarUsuarioVista_Load(object sender, EventArgs e)
        {
            u = bss.ObtenerUsuarioId(idx);
            textBox1.Text = u.IdPersona.ToString();
            textBox2.Text = u.NombreUser;
            textBox3.Text = u.Contraseña;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static int IdPersonaSeleccionada = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            u.IdPersona = IdPersonaSeleccionada;
            u.NombreUser = textBox2.Text;
            u.Contraseña = textBox3.Text;
            u.FechaReg = dateTimePicker1.Value;


            bss.EditarUsuarioId(u);
            MessageBox.Show("Se actualizó correctamente!");
        }

        PersonaBss BssPersona = new PersonaBss();
        private void button3_Click(object sender, EventArgs e)
        {
            PersonaListarVista plv = new PersonaListarVista();
            if (plv.ShowDialog() == DialogResult.OK)
            {
                Persona persona = BssPersona.ObtenerIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }
    }
}
