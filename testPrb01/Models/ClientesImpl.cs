using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace testPrb01.Models
{
    public class ClientesImpl
    {
        accessData con = new accessData();

        public int insertClient(Clientes cl)
        {
            StringBuilder st = new StringBuilder();
            st.Append("INSERT INTO clientes VALUES(");            
            st.Append("'" + cl.nombre + "',");
            st.Append("'" + cl.paterno + "',");
            st.Append("'" + cl.materno + "',");
            st.Append("'" + cl.sexo + "',");
            st.Append("'" + cl.estado + "');");

            con.connection.Open();
            int result = con.executeQuery(st.ToString());
            con.connection.Close();
            return result;
        }

        public List<Clientes> listClient()
        {
            List<Clientes> lista = new List<Clientes>();
            SqlDataReader reader = null;
            string query = "SELECT * FROM clientes;";
            con.connection.Open();
            reader = con.executeReader(query);
            while (reader.Read())
            {
                Clientes cli = new Clientes()
                {
                    idCliente = (int)reader["idCliente"],
                    nombre = reader["nombre"].ToString(),
                    paterno = reader["paterno"].ToString(),
                    materno = reader["materno"].ToString(),
                    sexo = reader["sexo"].ToString(),
                    estado = reader["estado"].ToString(),
                };
                lista.Add(cli);

            }
            reader.Close();
            con.connection.Close();
            return lista;
        }
    }
}