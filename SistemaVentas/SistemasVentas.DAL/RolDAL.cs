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

        public Rol ObternerIdDal (int id)
        {
            string consulta = "SELECT * FROM ROL WHERE IDROL= " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "tabla");
            Rol rol = new Rol();
            if (tabla.Rows.Count > 0)
            {
                rol.IdRol = Convert.ToInt32(tabla.Rows[0]["idrol"]);
                rol.Nombre = tabla.Rows[0]["nombre"].ToString();
                rol.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return rol;
        }


        public void EditarRolDal (Rol rol)
        {
            string consulta = "UPDATE ROL SET nombre = '"+rol.Nombre+"' ," +
                                              "estado = 'Activo' " +
                              "WHERE IDROL =" + rol.IdRol;
            Conexion.Ejecutar(consulta);
        }

        public void EliminarRolDal (int id)
        {
            string consulta = "DELETE FROM ROL WHERE IDROL= " + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
