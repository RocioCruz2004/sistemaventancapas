using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class ClienteDAL
    {
        public DataTable ListarClientesDal()
        {
            string consulta = "SELECT * FROM CLIENTE";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarClientesDal(Cliente cliente)
        {
            string consulta = "INSERT INTO CLIENTE VALUES ( " + cliente.IdPersona + ", " +
                                                            " '" + cliente.TipoCliente + "', " +
                                                            " '" + cliente.CodigoCliente + "', " +
                                                            " 'Activo')";
            Conexion.Ejecutar(consulta);
        }
    }
}
