﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class UsuarioRolDAL
    {
        public DataTable ListarUsuarioRolDal()
        {
            string consulta = "SELECT * FROM USUARIOROL";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
    }
}
