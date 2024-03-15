using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemasVentas.DAL
{
    public class Conexion
    {

        public static string CONECTAR
        {
            //data source, va el server name, si se lo deja en local deberia de funcionar, gral
            //Initial Catalog, nombre de la base de datos ya creada
            //lo demas son permisos para acceder a la base de datos
            get { return @"Data Source=DESKTOP-JHGTI79; Initial Catalog=tienda_Rocio; Integrated Security=True; TrustServerCertificate=true;"; }
            //get { return ConfigurationManager.ConnectionStrings["cadena"].ToString(); }
        }
        public static DataSet EjecutarDataSet(string consulta)
        {
            string p = Conexion.CONECTAR;
            SqlConnection conectar = new SqlConnection(Conexion.CONECTAR);
            conectar.Open();
            SqlCommand cmd = new SqlCommand(consulta, conectar);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "TABLA");
            return ds;
        }

        public static void Ejecutar(string consulta) 
        {
            //consulta tipo sql, alguien mandara un comando sql (INSERT INTO)
            SqlConnection conectar = new SqlConnection(Conexion.CONECTAR);
            conectar.Open();
            SqlCommand cmd = new SqlCommand(consulta, conectar);
            cmd.CommandTimeout = 5000;
            cmd.ExecuteNonQuery();
        }

        public static int EjecutarEscalar(string consulta)
        {
            //funciones escalares, de agregado: SUM, AVG, COUNT, MIN, MAX
            SqlConnection conectar = new SqlConnection(Conexion.CONECTAR);
            conectar.Open();

            SqlCommand cmd = new SqlCommand(consulta, conectar);
            cmd.CommandTimeout = 5000;
            int dev = Convert.ToInt32(cmd.ExecuteScalar());
            return dev;
        }
        public static DataTable EjecutarDataTabla(string consulta, string tabla)
        {
            string p = Conexion.CONECTAR;
            SqlConnection conectar = new SqlConnection(Conexion.CONECTAR);
            SqlCommand cmd = new SqlCommand(consulta, conectar);
            cmd.CommandTimeout = 5000;
            SqlDataAdapter da = new SqlDataAdapter(); //esto convierte los resultados, las listas
            da.SelectCommand = cmd; //hace que se pueda manipular desde cualquier boton etc de capa VISTA
            DataTable dt = new DataTable(tabla);
            da.Fill(dt);
            return dt;
        }

    }
}
