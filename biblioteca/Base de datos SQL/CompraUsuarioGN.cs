using biblioteca.Archivos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca.Base_de_datos_SQL
{
    public class CompraUsuarioGN : Consulta, IModificable<CompraUsuario>
    {
        public CompraUsuarioGN() : base("Server=.;Database=usuarios;Trusted_Connection=True;")
        {

        }

        public void AgregarAsync(CompraUsuario objeto)
        {
            if (objeto is not null) 
            {
                EjecutarNonQuery($"INSERT INTO registrocompras (cantidad, fecha, user_id, producto_id) " +
                  $"VALUES ('{objeto.cantidad}', '{objeto.Fecha}', '{objeto.Usuario.Id}','{objeto.Componente.Id}')");
            }
           
        }

        public void Borrar(int id)
        {
            if (id >= 0) 
            {
                EjecutarNonQuery($"DELETE FROM registrocompras WHERE id = {id}");
            }
            
        }

        public void Editar(CompraUsuario objeto)
        {
            if (objeto is not null) 
            {
                EjecutarNonQuery($"UPDATE registrocompras SET cantidad = '{objeto.cantidad}', fecha = '{objeto.Fecha}', user_id = '{objeto.Usuario.Id}', producto = '{objeto.Componente.Nombre}' WHERE id = '{objeto.Id}'");
            }
           
        }

        public List<CompraUsuario> TraerAsync()
        {
            var compras = new List<CompraUsuario>();

            var dataTable = EjecutarQuery("SELECT * FROM registrocompras");

            try
            {
                Sistema sistema = new();
                SistemaComp comp = new();
                foreach (DataRow item in dataTable.Rows)
                {
                    var id = Convert.ToInt32(item["id"]);
                    int cantidad = Convert.ToInt32(item["cantidad"]);
                    DateTime fecha = Convert.ToDateTime(item["fecha"]);
                    int userId = Convert.ToInt32(item["user_id"]);
                    int productoId = Convert.ToInt32(item["producto_id"]);

                    var user = sistema.GetObjeto(userId);
                    var producto = comp.GetObjeto(productoId);

                    compras.Add(new(id, producto, cantidad, fecha, user));
                }


            }
            catch (Exception ex)
            {
                new Exception("error al conectarse a la base de datos");
                Ticket.GeneradorDeErrores(ex.Message, "public List<Cliente> TraerAsync()");
            }

           return compras; 
          

        }

        public CompraUsuario TraerAsync(int id)
        {
            var lista = TraerAsync();

            foreach (var item in lista)
            {
                if (item.Id == id)
                {

                    return item;

                }
            }
            throw new Exception("No se encontro una compra de un usuario con esa id");
        }
    }
}
