using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class UsuarioDAL
    {
        public DataTable ListarUsuarioDal()
        {
            string consulta = "SELECT * FROM USUARIO";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarUsuarioDal(Usuario usuario)
        {
            string consulta = "INSERT INTO USUARIO VALUES (" + usuario.IdPersona + " , " +
                                                            " '" + usuario.NombreUser + "' , " +
                                                            " '" + usuario.Contraseña + "' , " +
                                                            " '" + usuario.FechaReg + "')";
            Conexion.Ejecutar(consulta);
        }
    }
}
