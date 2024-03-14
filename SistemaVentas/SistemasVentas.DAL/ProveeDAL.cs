using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
