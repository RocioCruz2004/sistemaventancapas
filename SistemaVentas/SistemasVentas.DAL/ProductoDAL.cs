using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class ProductoDAL
    {
        public DataTable ListarProductoDal()
        {
            string consulta = "SELECT * FROM PRODUCTO";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarProductoDal(Producto producto)
        {
            string consulta = "INSERT INTO PRODUCTO VALUES ( " + producto.IdTipoProd + " , " +
                                                             " " + producto.IdMarca + " , " +
                                                             " '" + producto.Nombre + "' , " +
                                                             " '" + producto.CodigoBarra + "' , " +
                                                             " " + producto.Unidad + " , " +
                                                             " '" + producto.Descripcion + "' , " +
                                                             " 'Activo' )";
            Conexion.Ejecutar(consulta);
        }
    }
}
