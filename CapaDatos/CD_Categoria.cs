using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CD_Categoria
    {
        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();

            using (SqlConnection oConexion = new SqlConnection(conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT codigo_ca, descripcion_ca, estado FROM TB_CATEGORIAS");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;

                    oConexion.Open();

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Categoria()
                            {
                                codigo_ca = Convert.ToInt32(reader["codigo_ca"]),
                                descripcion_ca = reader["descripcion_ca"].ToString(),
                                estado = Convert.ToBoolean(reader["estado"])

                            });
                        }
                    }

                }
                catch (Exception ex){ 
                    lista = new List<Categoria>();
                    MessageBox.Show("ERROR", "SALIO ESTE TERRIBLE ERROR" + ex.StackTrace);
                }

                return lista;
            }
        }

        public string GuardarCategoria(int nOpcion, Categoria categoria)
        {
            string respuesta = "";
           
            try
            {
                using (SqlConnection oConexion = new SqlConnection(conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_GUARDARCATEGORIA", oConexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("nOpcion",SqlDbType.Int).Value = nOpcion;
                    cmd.Parameters.Add("nCodigo_ca", SqlDbType.Int).Value = categoria.codigo_ca;
                    cmd.Parameters.AddWithValue("cDescripcion_Ca", categoria.descripcion_ca);
                    
                    oConexion.Open();

                    respuesta = cmd.ExecuteNonQuery() == 1 ? "OK" : "NO SE PUEDE REGISTRAR LOS DATOS";
                }

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }

            return respuesta;
        }
    }
}
