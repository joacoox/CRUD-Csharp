using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using biblioteca.Archivos;

namespace biblioteca.Base_de_datos_SQL
{
    public class Consulta : ConexionGN
    {
        private static SqlCommand _command;
        public Consulta(string _connection) : base(_connection)// string de conexion 
        {
            _command = new SqlCommand();
            _command.CommandType = CommandType.Text;
        }

        protected DataTable EjecutarQuery(string query)
        {
            try
            {
                Conectar();

                _command.Connection = _connection;
                _command.CommandText = query;

                var sqlReader = _command.ExecuteReader();

                var dataTable = new DataTable();

                dataTable.Load(sqlReader);

                sqlReader.Close();
                return dataTable;
            }
            catch(Exception ex) 
            {
                new Exception("error al mandar la query");
                Ticket.GeneradorDeErrores(ex.Message, " protected DataTable EjecutarQuery(string query)");
            }
            finally
            {
                Cerrar();
            }
            return new DataTable();
        }

        protected void EjecutarNonQuery(string query)
        {
            try
            {
                Conectar();

                _command.Connection = _connection;
                _command.CommandText = query;
                int affectedRows = _command.ExecuteNonQuery();         
            }
            catch(Exception ex)
            {
                new Exception("error al mandar la nonquery");
                Ticket.GeneradorDeErrores(ex.Message, "protected int EjecutarNonQuery(string query)");
            }
            finally
            {
                Cerrar();
            }

        }
    }
}
