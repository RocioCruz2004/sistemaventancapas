using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class IngresoDAL
    {
        public DataTable ListarIngresoDal()
        {
            string consulta = "SELECT * FROM INGRESO";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarIngresoDal(Ingreso ingreso)
        {
            string consulta = "INSERT INTO INGRESO VALUES( " + ingreso.IdProveedor + ", " +
                                                           " '" + ingreso.FechaIngreso + "', " +
                                                           " " + ingreso.Total + ", " +
                                                           " 'Activo')";
            Conexion.Ejecutar(consulta);
        }
    }
}
