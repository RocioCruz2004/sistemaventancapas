using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
