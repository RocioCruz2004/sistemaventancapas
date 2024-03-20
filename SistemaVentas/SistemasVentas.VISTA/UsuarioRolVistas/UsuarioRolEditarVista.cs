using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.RolVistas;
using SistemasVentas.VISTA.UsuarioVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.UsuarioRolVistas
{
    public partial class UsuarioRolEditarVista : Form
    {
        UsuarioRol ur = new UsuarioRol();
        UsuarioRolBss BssUsRol = new UsuarioRolBss();
        int idx = 0;
        public UsuarioRolEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        public static int IdUsuarioSeleccionado = 0;
        UsuarioBss BssUsuario = new UsuarioBss();
        private void button5_Click(object sender, EventArgs e)
        {
            UsuarioListarVista ulv = new UsuarioListarVista();
            if (ulv.ShowDialog() == DialogResult.OK)
            {
                Usuario usuario = BssUsuario.ObtenerUsuarioId(IdUsuarioSeleccionado);
                textBox1.Text = usuario.NombreUser;
            }
        }

        public static int IdRolSeleccionado = 0;
        RolBss BssRol = new RolBss();
        private void button3_Click(object sender, EventArgs e)
        {
            RolListarVista rlv = new RolListarVista();
            if (rlv.ShowDialog() == DialogResult.OK)
            {
                Rol rol = BssRol.ObtenerIdBss(IdRolSeleccionado);
                textBox2.Text = rol.Nombre;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ur.IdUsuario = IdUsuarioSeleccionado;
            ur.IdRol = IdRolSeleccionado;
            ur.FechaAsigna = dateTimePicker1.Value;

            BssUsRol.EditarUsuarioRol(ur);
            MessageBox.Show("Se editó correctamente!");
        }

        private void UsuarioRolEditarVista_Load(object sender, EventArgs e)
        {
            ur = BssUsRol.ObtenerUsuarioRolId(idx);
            textBox1.Text = ur.IdUsuario.ToString();
            textBox2.Text = ur.IdRol.ToString();

        }
    }
}
