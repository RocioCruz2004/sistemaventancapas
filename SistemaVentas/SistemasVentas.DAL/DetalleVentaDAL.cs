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

        public void EditarDetalleVentaDal(DetalleVenta dv)
        {
            string consulta = "UPDATE DETALLEVENTA SET idventa = " + dv.IdVenta + " ," +
                                                     "idproducto = " + dv.IdProducto + " , " +
                                                     "cantidad = " + dv.Cantidad + " ," +
                                                     "precioventa = " + dv.PrecioVenta + " ," +
                                                     "subtotal = " + dv.Subtotal + " ," +
                                                     "estado = '"+dv.Estado+"' " +
                              "WHERE IDDETALLEVENTA =" + dv.IdDetalleVenta;
            Conexion.Ejecutar(consulta);
        }
        

        DetalleVenta dv = new DetalleVenta();
        public DetalleVenta ObtenerDetalleVentaIdDal(int id)
        {
            string consulta = "SELECT * FROM DETALLEVENTA WHERE IDDETALLEVENTA= " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "tabla");
            if (tabla.Rows.Count > 0)
            {
                dv.IdDetalleVenta = Convert.ToInt32(tabla.Rows[0]["iddetalleventa"]);
                dv.IdVenta = Convert.ToInt32(tabla.Rows[0]["idventa"]);
                dv.IdProducto = Convert.ToInt32(tabla.Rows[0]["idproducto"]);
                dv.Cantidad = Convert.ToInt32(tabla.Rows[0]["cantidad"]);
                dv.PrecioVenta = Convert.ToDecimal(tabla.Rows[0]["precioventa"]);
                dv.Subtotal = Convert.ToDecimal(tabla.Rows[0]["subtotal"]);
            }
            return dv;
        }

        public void EliminarDetalleVentaDal(int id)
        {
            string consulta = "DELETE FROM DETALLEVENTA WHERE IDDETALLEVENTA = " + id;
            Conexion.Ejecutar(consulta);
        }
    }
}