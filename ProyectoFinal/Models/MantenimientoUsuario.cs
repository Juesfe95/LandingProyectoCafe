using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Models
{
    public class MantenimientoUsuario
    {
        private SqlConnection conexion;

        private void Conectar()
        {
            string constr = ConfigurationManager.ConnectionStrings["conectBd"].ToString();
            conexion = new SqlConnection(constr);
        }
    }
}