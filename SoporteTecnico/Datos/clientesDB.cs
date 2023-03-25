using MySql.Data.MySqlClient;
using System.Data;
using System.Text;

namespace Datos
{
    public class clientesDB
    {
        string cadena = "server=localhost; user=root; database=factura; password=1234567";
        public bool Insentar(Cliente por)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO clientes VALUES ");
                sql.Append("(@identidad, @nombre, @telefono, @Correo, @Fechanacimiento, @estaactivo, @rol)");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@identidad", MySqlDbType.VarChar, 50).Value = por.identidad;
                        comando.Parameters.Add("@nombre", MySqlDbType.VarChar, 50).Value = por.Nombre;
                        comando.Parameters.Add("@telefono", MySqlDbType.VarChar, 80).Value = por.telefono;
                        comando.Parameters.Add("@correo", MySqlDbType.VarChar, 45).Value = por.Correo;
                        comando.Parameters.Add("@Fechanacimiento", MySqlDbType.DateTime).Value = por.FechaNacimiento;
                        comando.Parameters.Add("@estaactivo", MySqlDbType.Bit).Value = por.EstaActivo;
                        comando.Parameters.Add("@rol", MySqlDbType.VarChar, 20).Value = por.Rol;

                        comando.ExecuteNonQuery();
                        inserto = true;

                    }


                }


            }
            catch (System.Exception ex)
            {


            }
            return inserto;
        }


        public bool editar(clientesDB usercli)
        {
            bool edito = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("UPDATE clientes SET ");
                sql.Append("nombre = @Nombre, telefono = @telefono, correo = @correo, estaactivo = @estaactivo)");
                sql.Append("WHERE identidad = @identidad");


                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@identidad", MySqlDbType.VarChar, 50).Value = usercli.identidad;
                        comando.Parameters.Add("@nombre", MySqlDbType.VarChar, 50).Value = usercli.Nombre;
                        comando.Parameters.Add("telefono", MySqlDbType.VarChar, 80).Value = usercli.telefono;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = usercli.Correo;
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = usercli.EstaActivo;
                        comando.Parameters.Add("@Rol", MySqlDbType.VarChar, 20).Value = usercli.Rol;

                        comando.ExecuteNonQuery();
                        edito = true;

                    }


                }


            }
            catch (System.Exception ex)
            {


            }
            return edito;
        }

        public bool Eliminar(string identidad)
        {
            bool elimino = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("DELETE FROM clientes ");
                sql.Append("WHERE identidad = @identidad");


                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@identidad", MySqlDbType.VarChar, 50).Value = identidad;

                        comando.ExecuteNonQuery();
                        elimino = true;

                    }


                }


            }
            catch (System.Exception ex)
            {


            }
            return elimino;
        }

        public DataTable devolverclientes()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM  clientes ");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        MySqlDataReader dr = comando.ExecuteReader();
                        dt.Load(dr);

                    }


                }


            }
            catch (System.Exception ex)
            {


            }
            return dt;
        }



    }
}
