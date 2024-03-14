using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class PersonaDAL
    {
        public DataTable ListarPersonasDal()
        {
            string consulta = "SELECT * FROM PERSONA";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            //ejecutardatatabla para conseguir las filas
            return lista;
        }
    }
}
