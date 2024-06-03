using biblioteca.Archivos;
using biblioteca.Logica_Usuarios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca.Base_de_datos_SQL
{
    public class ClienteGN : Consulta, IModificable<Cliente>
    {
        public ClienteGN() : base("Server=.;Database=usuarios;Trusted_Connection=True;"){}

        public void AgregarAsync(Cliente objeto)
        {
            if (objeto is not null) 
            { 
            EjecutarNonQuery($"INSERT INTO datosBancarios (id_user, numeroTarjeta, CodigoDeSeguridad, fechaVencimiento, banco, saldo) VALUES ('{objeto.Id}', '{objeto.Datos.NumeroTarjeta}', '{objeto.Datos.CodigoSeguridad}', '{objeto.Datos.FechaVencimiento}', '{Convert.ToInt32(objeto.Datos.Banco)}', '{objeto.Datos.Saldo}')");
            }
            
        }

        public void Borrar(int id)
        {
            if (id >= 0)
            {
                 EjecutarNonQuery($"DELETE FROM datosBancarios WHERE id_user = {id}");
            }
           
        }

        public void Editar(Cliente objeto)
        {
            if (objeto is not null)
            {
                EjecutarNonQuery($"UPDATE datosBancarios SET id_user = '{objeto.Id}', numeroTarjeta = '{objeto.Datos.NumeroTarjeta}', CodigoDeSeguridad = '{objeto.Datos.CodigoSeguridad}', fechaVencimiento = '{objeto.Datos.FechaVencimiento}', banco = '{Convert.ToInt32(objeto.Datos.Banco)}', saldo = '{objeto.Datos.Saldo}'  WHERE id_user = '{objeto.Id}'");
            }
        }

        public List<Cliente> TraerAsync()
        {
            var clientes = new List<Cliente>();

            try
            { 
                var dataTable = EjecutarQuery("SELECT * FROM datosBancarios");
                Sistema sistema = new();
                foreach (DataRow item in dataTable.Rows)
                {
                    var id = Convert.ToInt32(item["id_user"]);
                    string numTarjeta = item["numeroTarjeta"].ToString().Trim();
                    int codigoSeguridad = Convert.ToInt32(item["codigoDeSeguridad"]);
                    string fechaVencimiento = item["fechaVencimiento"].ToString().Trim();
                    Banco banco = (Banco)Convert.ToInt32(item["banco"]);
                    int saldo = Convert.ToInt32(item["saldo"]);

                    var user = sistema.GetObjeto(id);

                    clientes.Add(new Cliente(new(numTarjeta, codigoSeguridad, fechaVencimiento, banco, saldo), id, user.Nombre, user.Contraseña));
                }
            }
            catch (Exception ex) 
            {
                new Exception("error al conectarse a la base de datos");
                Ticket.GeneradorDeErrores(ex.Message, "public List<Cliente> TraerAsync()");
            }
            

            return clientes;
        }

        public Cliente TraerAsync(int id)
        {
            var lista = TraerAsync();

            foreach (var item in lista)
            {
                if (item.Id == id)
                {                   
                    return item;
                }
            }
            throw new Exception("No se encontro un cliente con esa id");
        }
    }
}
