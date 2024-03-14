using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.DAL;

namespace SistemasVentas.BSS
{
    public class MarcaBss
    {
        MarcaDAL dal = new MarcaDAL();
        public DataTable ListarMarcaBss()
        {
            return dal.ListarMarcaDal();
        }
    }
}
