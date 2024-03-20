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
    public class UsuarioBss
    {
        UsuarioDAL dal = new UsuarioDAL();
        public DataTable ListarUsuarioBss()
        {
            return dal.ListarUsuarioDal();
        }
        public void InsertarUsuarioBss(Usuario usuario)
        {
            dal.InsertarUsuarioDal(usuario);
        }

        public Usuario ObtenerUsuarioId (int id)
        {
            return dal.ObtenerUsuarioId(id);
        }

        public void EditarUsuarioId (Usuario usuario)
        {
            dal.EditarUsuarioDal (usuario);
        }
        public void EliminarUsuarioBss (int id)
        {
            dal.EliminarUsuarioDal(id);
        }
    }
}
