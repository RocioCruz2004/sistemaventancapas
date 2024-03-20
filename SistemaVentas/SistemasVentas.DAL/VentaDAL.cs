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
            string consulta = "INSERT INTO VENTA VALUES ( " + venta.IdCliente + " , "
                                                          + + venta.IdVendedor + " , "
                                                          +" '" + venta.Fecha + "' , "
                                                          + venta.Total + " , "
                                                          +" 'Exitoso')";
            Conexion.Ejecutar(consulta);
        }

        public void VentaEditarDal(Venta v)
        {
            string consulta = "UPDATE VENTA SET idcliente = " + v.IdCliente + " ," +
                                                     "idvendedor = " +v.IdVendedor+ " , " +
                                                     "fechaAsigna = '" + v.Fecha + "' ," +
                                                     "total = " + v.Total + " ," +
                                                     "estado = 'Activo' " +
                              "WHERE IDVENTA =" + v.IdVenta;
            Conexion.Ejecutar(consulta);
        }
        public void EditarUsuarioRolDal(Venta v)
        {
            string consulta = "update VENTA set idcliente=" + v.IdCliente + "," +
                                                        "idvendedor=" + v.IdVendedor + "," +
                                                        "fechaasigna='" + v.Fecha + "', " +
                                                        "estado='" + v.Estado + "' " +
                                                "where idventa=" + v.IdVenta;
            Conexion.Ejecutar(consulta);
        }

        Venta v = new Venta();
        public Venta ObtenerVentaId(int id)
        {
            string consulta = "SELECT * FROM VENTA WHERE IDVENTA= " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "tabla");
            if (tabla.Rows.Count > 0)
            {
                v.IdVenta = Convert.ToInt32(tabla.Rows[0]["idventa"]);
                v.IdCliente = Convert.ToInt32(tabla.Rows[0]["idcliente"]);
                v.IdVendedor = Convert.ToInt32(tabla.Rows[0]["idvendedor"]);
                v.Fecha = Convert.ToDateTime(tabla.Rows[0]["fecha"]);
                v.Total = Convert.ToDecimal(tabla.Rows[0]["total"]);
            }
            return v;
        }

        public void EliminarVentaDal(int id)
        {
            string consulta = "DELETE FROM VENTA WHERE IDVENTA = " + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
