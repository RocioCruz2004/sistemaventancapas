using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemasVentas.Modelos;
using SistemasVentas.BSS;

namespace SistemasVentas.VISTA.RolVistas
{
    public partial class RolEditarVista : Form
    {
        Rol r = new Rol();
        RolBss bss = new RolBss();
        int idx = 0;
        public RolEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void RolEditarVista_Load(object sender, EventArgs e)
        {
            r = bss.ObtenerIdBss(idx);
            textBox1.Text = r.Nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            r.Nombre = textBox1.Text;

            bss.EditarRolBss(r);
            MessageBox.Show("Se editó correctamente el rol!");
        }
    }
}
