using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.ClienteVistas;
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

namespace SistemasVentas.VISTA.VentaVistas
{
    public partial class VentaEditarVista : Form
    {
        Venta v = new Venta();
        VentaBss bss = new VentaBss();
        int idx = 0;
        public VentaEditarVista(int id)
        {
            InitializeComponent();
            this.idx = id;
        }

        public static int IdClienteSeleccionado = 0;
        ClienteBss BssCl = new ClienteBss();

        private void button5_Click(object sender, EventArgs e)
        {
            ClienteListarVista clv = new ClienteListarVista();
            if (clv.ShowDialog() == DialogResult.OK)
            {
                Cliente cliente = BssCl.ObtenerClienteId(IdClienteSeleccionado);
                textBox1.Text = cliente.TipoCliente;
            }
        }

        public static int IdUsuarioSeleccionado = 0;
        UsuarioBss BssUs = new UsuarioBss();
        private void button3_Click(object sender, EventArgs e)
        {
            UsuarioListarVista rlv = new UsuarioListarVista();
            if (rlv.ShowDialog() == DialogResult.OK)
            {
                Usuario usuario = BssUs.ObtenerUsuarioId(IdUsuarioSeleccionado);
                textBox2.Text = usuario.NombreUser;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            v.IdCliente = IdClienteSeleccionado;
            v.IdVendedor = IdUsuarioSeleccionado;
            v.Fecha = dateTimePicker1.Value;
            v.Total = Convert.ToDecimal(textBox3.Text);

            bss.EditarVentaBss(v);
            MessageBox.Show("Se editó correctamente!");
        }

        private void VentaEditarVista_Load(object sender, EventArgs e)
        {
            v = bss.ObtenerVentaId(idx);
            textBox1.Text = v.IdCliente.ToString();
            textBox2.Text = v.IdVendedor.ToString();
            textBox3.Text = v.Total.ToString();
        }
    }
}
