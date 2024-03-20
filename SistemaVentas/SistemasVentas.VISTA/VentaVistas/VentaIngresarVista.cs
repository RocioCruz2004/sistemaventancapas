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
using SistemasVentas.VISTA.ClienteVistas;
using SistemasVentas.VISTA.RolVistas;
using SistemasVentas.VISTA.UsuarioVistas;

namespace SistemasVentas.VISTA.VentaVistas
{
    public partial class VentaIngresarVista : Form
    {
        public VentaIngresarVista()
        {
            InitializeComponent();
        }

        VentaBss bss = new VentaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Venta v = new Venta();
            v.IdCliente = IdClienteSeleccionado;
            v.IdVendedor = IdVendedorSeleccionado;
            v.Fecha = dateTimePicker1.Value;
            v.Total = Convert.ToDecimal(textBox3.Text);

            bss.InsertarVentaBss(v);
            MessageBox.Show("Se guardó correctamente!");
        }

        public static int IdClienteSeleccionado = 0;
        ClienteBss BssCliente = new ClienteBss();
        private void button5_Click(object sender, EventArgs e)
        {
            ClienteListarVista usv = new ClienteListarVista();
            if (usv.ShowDialog() == DialogResult.OK)
            {
                Cliente cliente = BssCliente.ObtenerClienteId(IdClienteSeleccionado);
                textBox1.Text = cliente.IdCliente.ToString();
            }
        }

        public static int IdVendedorSeleccionado = 0;
        UsuarioBss BssUs = new UsuarioBss();
        private void button3_Click(object sender, EventArgs e)
        {
            UsuarioListarVista fr = new UsuarioListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Usuario usuario = BssUs.ObtenerUsuarioId(IdVendedorSeleccionado);
                textBox2.Text = usuario.NombreUser;
            }
        }

        private void VentaIngresarVista_Load(object sender, EventArgs e)
        {

        }
    }
}
