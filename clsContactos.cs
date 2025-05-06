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
    internal class clsContactos
    {
        #region Métodos
        public void Mostrar(DataGridView dgvContactos)
        {
            using (SqlConnection connection = clsConexion.ConectarBase())
                try
                {
                    string query = @"SELECT Id, Nombre, Apellido, Telefono, Correo, CategoriaId
                                 FROM Contactos";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Utilizando un DataTable para almacenar los resultados
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    da.Fill(dt);  // Llenamos el DataTable con los resultados de la consulta

                    // Asignamos el DataTable al DataGridView
                    dgvContactos.DataSource = dt; // dgvContactos es el nombre de mi grilla

                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al conectar: " + ex.Message);
                }
        }

        public void Agregar(string Nombre, string Apellido, string Telefono, string Correo)
        {
            using (SqlConnection connection = clsConexion.ConectarBase())
                try
                {
                    string insertQuery = "INSERT INTO Contactos (Nombre, Apellido, Telefono, Correo) " +
                                         "VALUES (@Nombre, @Apellido, @Telefono, @Correo)";
                    SqlCommand cmd = new SqlCommand(insertQuery, connection);
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", Apellido);
                    cmd.Parameters.AddWithValue("@Telefono", Convert.ToInt32(Telefono));
                    cmd.Parameters.AddWithValue("@Correo", Correo);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("✅ Contacto agregado con éxito.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al agregar contacto: " + ex.Message);
                }
        }

        public void Eliminar(string Nombre)
        {
            using (SqlConnection connection = clsConexion.ConectarBase())
                try
                {
                    string deleteQuery = "DELETE FROM Contactos WHERE Nombre = @nombre";
                    SqlCommand cmd = new SqlCommand(deleteQuery, connection);
                    cmd.Parameters.AddWithValue("@nombre", Nombre);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("❌ Contacto eliminado.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al eliminar contacto: " + ex.Message);
                }
        }
        #endregion
    }
}
