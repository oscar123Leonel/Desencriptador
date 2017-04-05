using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportSystem.Controlador
{
    class Conexion
    {
        private MySqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public MySqlDataAdapter da;
        public MySqlCommand comando;
        public String CadenaConexion = "Server=localhost;Port=3306;Database=auditoria;Uid=root;Password=admin;";
        protected MySqlConnection con = new MySqlConnection();

        public void conectar1()
        {

            con.ConnectionString = CadenaConexion;
            try
            {
                con.Open();
            }
            catch
            {
                MessageBox.Show("error de conexion");

            }
            finally
            {
                con.Close();
            }

        }
        public void consulta(string sql, string tabla)
        {

            try
            {
                ds.Tables.Clear();
                da = new MySqlDataAdapter(sql, con);
                cmb = new MySqlCommandBuilder(da);
                da.Fill(ds, tabla);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        public Boolean insertar(String sql)
        {
            con.Open();
            comando = new MySqlCommand(sql, con);
            int i = comando.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool eliminar(string tabla, string condicion)
        {
            con.Open();
            string elimina = "delete from " + tabla + " where " + condicion;
            comando = new MySqlCommand(elimina, con);
            int i = comando.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool actualizar(string tabla, string campos, string condicion)
        {
            con.Open();
            string actualizar = "update " + tabla + " set " + campos + " where " + condicion;
            comando = new MySqlCommand(actualizar, con);
            int i = comando.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}