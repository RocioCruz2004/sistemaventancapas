﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.DAL;

namespace SistemasVentas.BSS
{
    public class TipoProdBss
    {
        TipoProdDAL dal = new TipoProdDAL();
        public DataTable ListarTipoProdBss()
        {
            return dal.ListarTipoProdDal();
        }
    }
}
