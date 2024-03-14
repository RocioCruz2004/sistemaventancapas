using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.DAL;

namespace SistemasVentas.BSS
{
    public class UsuarioRolBss
    {
        UsuarioDAL dal = new UsuarioDAL();
        public DataTable ListarUsuarioBss()
        {
            return dal.ListarUsuarioDal();
        }
    }
}
