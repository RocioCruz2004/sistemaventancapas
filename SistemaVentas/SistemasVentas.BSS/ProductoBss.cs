using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.DAL;

namespace SistemasVentas.BSS
{
    public class ProductoBss
    {
        ProductoDAL dal = new ProductoDAL();
        public DataTable ListarProductoBss()
        {
            return dal.ListarProductoDal();
        }
    }
}
