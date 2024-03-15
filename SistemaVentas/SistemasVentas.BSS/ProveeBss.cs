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
    public class ProveeBss
    {
        ProveeDAL dal = new ProveeDAL();
        public DataTable ListarProveeBss()
        {
            return dal.ListarProveeDal();
        }
        public void InsertarproveeBss(Provee provee)
        {
            dal.IngresarProveeDal(provee);
        }
    }
}
