using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class VentaDAL
    {
        public DataTable ListarVentaDal()
        {
            string consulta = "SELECT * FROM VENTA";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarVentaDal(Venta venta)
        {
            string consulta = "INSERT INTO VENTA VALUES ( " + venta.IdCliente + " , " +
                                                          " " + venta.IdVendedor + " , " +
                                                          " '" + venta.Fecha + "' , " +
                                                          " " + venta.Total + " , " +
                                                          " 'Exitoso')";
            Conexion.Ejecutar(consulta);
        }
    }
}
