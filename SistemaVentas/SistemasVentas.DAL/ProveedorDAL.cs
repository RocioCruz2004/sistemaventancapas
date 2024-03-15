using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class ProveedorDAL
    {
        public DataTable ListarProveedorDal()
        {
            string consulta = "SELECT * FROM PROVEEDOR";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarProveedorDal(Proveedor proveedor)
        {
            string consulta = "INSERT INTO PROVEEDOR VALUES ('" + proveedor.Nombre + "', " +
                                                               " '" + proveedor.Telefono + "', " +
                                                               " '" + proveedor.Direccion + "', " +
                                                               " 'Activo')";
            Conexion.Ejecutar(consulta);
        }
    }
}
