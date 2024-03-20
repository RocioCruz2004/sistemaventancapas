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
        Marca m = new Marca();
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
        public Marca ObtenerMarcaIdDal(int id)
        {
            string consulta = "select * from marca where idmarca=" + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "tabla");
            if (tabla.Rows.Count > 0)
            {
                m.IdMarca = Convert.ToInt32(tabla.Rows[0]["idmarca"]);
                m.Nombre = tabla.Rows[0]["nombre"].ToString();
            }
            return m;
        }
        public void EditarMarcaDal(Marca m)
        {
            string consulta = "update marca set nombre='" + m.Nombre + "' " +
                                                "where idmarca=" + m.IdMarca;
            Conexion.Ejecutar(consulta);
        }
        public void EliminarMarcaDal(int id)
        {
            string consulta = "delete from marca where idmarca=" + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
