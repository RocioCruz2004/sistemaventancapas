using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class RolDAL
    {
        public DataTable ListarRolDal()
        {
            string consulta = "SELECT * FROM ROL";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarRolDal(Rol rol)
        {
            string consulta = "INSERT INTO ROL VALUES('" + rol.Nombre + "', " +
                                                        " 'Activo')";
            Conexion.Ejecutar(consulta);
        }
    }
}
