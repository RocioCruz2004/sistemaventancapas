using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.DAL;
using SistemasVentas.Modelos;

namespace SistemasVentas.BSS
{
    public class ClienteBss
    {
        ClienteDAL dal = new ClienteDAL();
        public DataTable ListarClientesBss()
        {
            return dal.ListarClientesDal();
        }
        public void InsertarClientesBss(Cliente cliente)
        {
            dal.InsertarClientesDal(cliente);
        }
       public Cliente ObtenerClienteId (int id)
        {
            return dal.ObtenerClienteId(id);
        }

        public void EditarClienteBss(Cliente cliente)
        {
            dal.EditarClienteDal(cliente);
        }
        public void EliminarClienteBss(int id)
        {
            dal.EliminarClienteDal(id);
        }
    }
}
