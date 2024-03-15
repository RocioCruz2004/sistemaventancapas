using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

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
        public void InsertarPersonasDal(Persona persona )
        {
            string consulta = "INSERT INTO PERSONA VALUES('"+persona.Nombre+"',"+
                                                            "'" + persona.Apellido+"', "+
                                                            "'" + persona.Telefono+"', "+
                                                            "'" +persona.CI+"', "+
                                                            "'" +persona.Correo+"', " +
                                                            "'Activo')";
            Conexion.Ejecutar(consulta);
                                                            
        }
    }
}
