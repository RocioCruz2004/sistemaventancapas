using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class MarcaDAL
    {
        public DataTable ListarMarcaDal()
        {
            string consulta = "SELECT * FROM MARCA";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarMarcaDal(Marca marca)
        {
            string consulta = "INSERT INTO MARCA VALUES('" + marca.Nombre + "'," +
                                                            "'Activo')";
            Conexion.Ejecutar(consulta);

        }
    }
}
