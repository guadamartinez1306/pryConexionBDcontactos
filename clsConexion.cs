using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace pryConexionBDcontactos
{
    internal class clsConexion
    {
        #region Conexion
        private static string ConexionBD = "Server=localhost;Database=Comercio;Trusted_Connection=True;";

        public static SqlConnection ConectarBase()
        {
            SqlConnection conexion = new SqlConnection(ConexionBD);
            try
            {
                conexion.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al conectar: " + ex.Message);
            }

            return conexion;
        }
        #endregion
    }
}
