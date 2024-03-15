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
    public class UsuarioRolBss
    {
        UsuarioRolDAL dal = new UsuarioRolDAL();
        public DataTable ListarUsuarioRolBss()
        {
            return dal.ListarUsuarioRolDal();
        }
        public void InsertarUsuarioRol (UsuarioRol UsuarioRol)
        {
            dal.InsertarUsuarioRolDal(UsuarioRol);
        }

    }
}
