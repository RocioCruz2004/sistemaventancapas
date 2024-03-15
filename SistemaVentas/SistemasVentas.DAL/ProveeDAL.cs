using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class ProveeDAL
    {
        public DataTable ListarProveeDal()
        {
            string consulta = "SELECT * FROM PROVEE";
            DataTable listar = Conexion.EjecutarDataTabla(consulta, "tabla");
            return listar;
        }
        public void IngresarProveeDal(Provee provee)
        {
            string consulta = "INSERT INTO PROVEE VALUES (" + provee.IdProducto + " ," +
                                                          " " + provee.IdProveedor + " ," +
                                                          " '" + provee.Fecha + "' ," +
                                                          " " + provee.Precio + ")";
            Conexion.Ejecutar(consulta);
        }
    }
}
