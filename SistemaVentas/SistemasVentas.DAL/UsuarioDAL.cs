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

        public Usuario ObtenerUsuarioId(int id)
        {
            string consulta = "SELECT * FROM USUARIO WHERE IDUSUARIO = " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "tabla");
            Usuario usuario = new Usuario();
            if (tabla.Rows.Count > 0)
            {
                usuario.IdUsuario = Convert.ToInt32(tabla.Rows[0]["idusuario"]);
                usuario.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                usuario.NombreUser = tabla.Rows[0]["nombreuser"].ToString();
                usuario.Contraseña = tabla.Rows[0]["contraseña"].ToString();

            }
            return usuario;
        }

        public void EditarUsuarioDal(Usuario u)
        {
            string consulta = "UPDATE USUARIO SET idpersona= "+u.IdPersona+" ," +
                                                  "nombreuser= '"+u.NombreUser+"' ," +
                                                  "contraseña= '" + u.Contraseña + "' ," +
                                                  "fechareg= '" + u.FechaReg + "' " +
                              "WHERE IDUSUARIO=" + u.IdUsuario;
            Conexion.Ejecutar(consulta);
        }
        public void EliminarUsuarioDal (int id)
        {
            string consulta = "DELETE FROM USUARIO WHERE IDUSUARIO = " + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
