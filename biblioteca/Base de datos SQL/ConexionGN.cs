using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace biblioteca.Base_de_datos_SQL
{
    public abstract class ConexionGN
    {
        protected SqlConnection _connection;
        private string _connectionString;

        public ConexionGN(string connecString)
        {
            this._connectionString = connecString;
        }

        protected void Conectar()
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }

        protected void Cerrar()
        {
            _connection.Close();
        }
    }
}
