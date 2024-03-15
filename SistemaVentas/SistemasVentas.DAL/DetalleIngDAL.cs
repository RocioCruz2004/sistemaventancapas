using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class DetalleIngDAL
    {
        public DataTable ListarDetalleIngDal()
        {
            string consulta = "SELECT * FROM DETALLEING";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarDetalleIngDal(DetalleIng DetalleIng)
        {
            string consulta = "INSERT INTO DETALLEING VALUES ( " + DetalleIng.IdIngreso + " ," +
                                                               " " + DetalleIng.IdProducto + " ," +
                                                               " '" + DetalleIng.FechaVenc + "' ," +
                                                               " " + DetalleIng.Cantidad + " ," +
                                                               " " + DetalleIng.PrecioCosto + " ," +
                                                               " " + DetalleIng.PrecioVenta + " ," +
                                                               " " + DetalleIng.Subtotal + " ," +
                                                               " 'Exitoso')";
            Conexion.Ejecutar(consulta);
        }
    }
}
