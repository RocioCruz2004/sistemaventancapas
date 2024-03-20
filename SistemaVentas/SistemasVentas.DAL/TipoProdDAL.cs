using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class TipoProdDAL
    {
        public DataTable ListarTipoProdDal()
        {
            string consulta = "SELECT * FROM TIPOPROD";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarTipoProdDal(TipoProd tipoProd)
        {
            string consulta = "INSERT INTO TIPOPROD VALUES('" + tipoProd.Nombre + "' , " +
                                " 'Activo' )";
            Conexion.Ejecutar(consulta);
                                                            
        }

        TipoProd tp = new TipoProd();
        public TipoProd ObtenerTipoProdIdDal(int id)
        {
            string consulta = "SELECT * FROM TIPOPROD WHERE IDTIPOPROD= " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                tp.IdTipoProd = Convert.ToInt32(tabla.Rows[0]["idtipoprod"]);
                tp.Nombre = tabla.Rows[0]["nombre"].ToString();
            }
            return tp;
        }
        public void EditarTipoProdDal(TipoProd tp)
        {
            string consulta = "update tipoprod set nombre='" + tp.Nombre + "'" +
                                                "where idtipoprod=" + tp.IdTipoProd;
            Conexion.Ejecutar(consulta);
        }
        public void EliminarTipoProdDal(int id)
        {
            string consulta = "delete from tipoprod where idtipoprod=" + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
