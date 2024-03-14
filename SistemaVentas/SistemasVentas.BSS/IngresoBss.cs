using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.DAL;

namespace SistemasVentas.BSS
{
    public class IngresoBss
    {
        IngresoDAL dal = new IngresoDAL();
        public DataTable ListarIngresoBss()
        {
            return dal.ListarIngresoDal();
        }
    }
}
