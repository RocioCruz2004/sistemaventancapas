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
    public class DetalleVentaBss
    {
        DetalleVentaDAL dal = new DetalleVentaDAL();
        public DataTable ListarDetalleVentaBss()
        {
            return dal.ListarDetalleVentaDal();
        }
        public void InsertarDetalleVentaBss(DetalleVenta DetalleVenta)
        {
            dal.InsertarDetalleVentaDal(DetalleVenta);
        }

        public void EditarDetalleVentaBss(DetalleVenta dv)
        {
            dal.EditarDetalleVentaDal(dv);
        }

        public DetalleVenta ObtenerDetalleVentaId(int id)
        {
            return dal.ObtenerDetalleVentaIdDal(id);
        }

        public void EliminarDetalleVentaBss(int id)
        {
            dal.EliminarDetalleVentaDal(id);
        }
    }
}
