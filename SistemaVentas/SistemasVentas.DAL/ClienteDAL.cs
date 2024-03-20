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

        public Cliente ObtenerClienteId (int id)
        {
            string consulta = "SELECT * FROM CLIENTE WHERE IDCLIENTe =" + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "tabla");
            Cliente cliente = new Cliente();
            if (tabla.Rows.Count > 0) {
                cliente.IdCliente = Convert.ToInt32(tabla.Rows[0]["IdCliente"]);
                cliente.IdPersona = Convert.ToInt32(tabla.Rows[0]["IdPersona"]);
                cliente.TipoCliente = tabla.Rows[0]["TipoCliente"].ToString();
                cliente.CodigoCliente = tabla.Rows[0]["CodigoCliente"].ToString();
            }
            return cliente;
        }
        
        public void EditarClienteDal(Cliente c)
        {
            string consulta = "UPDATE CLIENTE SET IDPERSONA= " + c.IdPersona + " ," +
                                                        "tipocliente='" + c.TipoCliente + "'," +
                                                        "codigocliente='" + c.CodigoCliente + "'" +
                                                        "estado='" + c.Estado + "' " +
                                                "WHERE IDCLIENTE=" + c.IdCliente;
            Conexion.Ejecutar(consulta);
        }
        public void EliminarClienteDal(int id)
        {
            string consulta = "DELETE FROM CLIENTE WHERE IDCLIENTE = " + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
