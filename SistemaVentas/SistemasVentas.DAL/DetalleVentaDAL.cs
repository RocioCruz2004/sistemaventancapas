using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class DetalleVentaDAL
    {
        public DataTable ListarDetalleVentaDal()
        {
            string consulta = "SELECT * FROM DETALLEVENTA";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarDetalleVentaDal(DetalleVenta DetalleVenta)
        {
            string consulta = "INSERT INTO DETALLEVENTA VALUES ( " + DetalleVenta.IdVenta + " ," +
                                                                 " " + DetalleVenta.IdProducto + " ," +
                                                                 " " + DetalleVenta.Cantidad + " ," +
                                                                 " " + DetalleVenta.PrecioVenta + " ," +
                                                                 " " + DetalleVenta.Subtotal + " ," +
                                                                 " 'Exitoso')";
            Conexion.Ejecutar(consulta);
        }
    }
}