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
    }
}
