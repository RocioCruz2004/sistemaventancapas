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
    
    public class RolBss
    {
        RolDAL dal = new RolDAL();
        public DataTable ListarRolBss()
        {
            return dal.ListarRolDal();
        }
        public void InsertarRolBss(Rol rol)
        {
            dal.InsertarRolDal(rol);
        }

        public Rol ObtenerIdBss(int id)
        {
            return dal.ObternerIdDal(id);
        }

        public void EditarRolBss(Rol rol)
        {
            dal.EditarRolDal(rol);
        }

        public void EliminarRolBss(int id)
        {
            dal.EliminarRolDal(id);
        }

    }
}
