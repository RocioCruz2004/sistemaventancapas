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
using SistemasVentas.VISTA.RolVistas;
using SistemasVentas.VISTA.UsuarioVistas;

namespace SistemasVentas.VISTA.UsuarioRolVistas
{
    public partial class UsuarioRolInsertarVista : Form
    {
        public UsuarioRolInsertarVista()
        {
            InitializeComponent();
        }

        UsuarioRolBss bss = new UsuarioRolBss();
        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioRol ur = new UsuarioRol();
            ur.IdUsuario = IdUsuarioSeleccionado;
            ur.IdRol = IdRolSeleccionado;
            ur.FechaAsigna = dateTimePicker1.Value;

            bss.InsertarUsuarioRol(ur);
            MessageBox.Show("Se guardo correctamente!");
        }
        public static int IdUsuarioSeleccionado = 0;
        UsuarioBss bssUsuario = new UsuarioBss();
        private void button5_Click(object sender, EventArgs e)
        {
            UsuarioListarVista usv = new UsuarioListarVista();
            if (usv.ShowDialog() == DialogResult.OK)
            {
                Usuario usuario = bssUsuario.ObtenerUsuarioId(IdUsuarioSeleccionado);
                textBox1.Text = usuario.NombreUser;
            }
        }

        public static int IdRolSeleccionado = 0;
        RolBss bssRol = new RolBss();
        private void button3_Click(object sender, EventArgs e)
        {
            RolListarVista fr = new RolListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Rol rol = bssRol.ObtenerIdBss(IdRolSeleccionado);
                textBox2.Text = rol.Nombre;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsuarioRolInsertarVista_Load(object sender, EventArgs e)
        {

        }
    }
}
