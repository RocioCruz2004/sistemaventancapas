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

        public void UsuarioRolEditarDal (UsuarioRol ur)
        {
            string consulta = "UPDATE USUARIOROL SET idusuario = " + ur.IdUsuario + " ," +
                                                     "idrol = " + ur.IdRol + " , " +
                                                     "fechaAsigna = '" + ur.FechaAsigna + "' ," +
                                                     "estado = 'Activo' " +
                              "WHERE IDUSUARIOROL =" + ur.IdUsuarioRol;
            Conexion.Ejecutar(consulta);
        }
        public void EditarUsuarioRolDal(UsuarioRol p)
        {
            string consulta = "update usuariorol set idusuario=" + p.IdUsuario + "," +
                                                        "idrol=" + p.IdRol + "," +
                                                        "fechaasigna='" + p.FechaAsigna + "', " +
                                                        "estado='" + p.Estado + "' " +
                                                "where idusuariorol=" + p.IdUsuarioRol;
            Conexion.Ejecutar(consulta);
        }

        UsuarioRol ur = new UsuarioRol();
        public UsuarioRol ObtenerUsuarioRolId (int id)
        {
            string consulta = "SELECT * FROM USUARIOROL WHERE IDUSUARIOROL= " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "tabla");
            if (tabla.Rows.Count > 0)
            {
                ur.IdUsuarioRol = Convert.ToInt32(tabla.Rows[0]["IdUsuarioRol"]);
                ur.IdUsuario = Convert.ToInt32(tabla.Rows[0]["IdUsuario"]);
                ur.IdRol = Convert.ToInt32(tabla.Rows[0]["IdRol"]);
            }
            return ur;
        }

        public void EliminarUsuarioDal(int id)
        {
            string consulta = "DELETE FROM USUARIOROL WHERE IDUSUARIOROL = " + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
