using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class UsuarioRolDAL
    {
        public DataTable ListarUsuarioRolDal()
        {
            string consulta = "SELECT * FROM USUARIOROL";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarUsuarioRolDal(UsuarioRol usuariorol)
        {
            string consulta = "INSERT INTO USUARIOROL VALUES ( " + usuariorol.IdUsuario + ", " +
                                                               " " + usuariorol.IdRol + ", " +
                                                               " '" + usuariorol.FechaAsigna + "', " +
                                                               " 'Activo')";
            Conexion.Ejecutar(consulta); 
        }
    }
}
