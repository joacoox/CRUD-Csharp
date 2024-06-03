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
    public class ComponenteGN : Consulta, IModificable<Componente>
    {
        public ComponenteGN() : base("Server=.;Database=usuarios;Trusted_Connection=True;"){}

        public void AgregarAsync(Componente objeto)
        {
            if (objeto is not null) 
            {
                EjecutarNonQuery($"INSERT INTO componentes (nombre, marca, Color_id, stock, precio, descripcion, TipoDeProducto_id, rgb) " +
                    $"VALUES ('{objeto.Nombre}', '{objeto.Marca}', '{Convert.ToInt32(objeto.Color)}','{objeto.Stock}','{objeto.Precio}','{objeto.DescripcionProducto}','{Convert.ToInt32(objeto.TipoProducto)}','{Convert.ToString(objeto.Rgb)}')");
            }
            
        }

        public void Borrar(int id)
        {
            if (id >= 0) 
            { 
                EjecutarNonQuery($"DELETE FROM componentes WHERE id = {id}");
            }
            
        }

        public void Editar(Componente objeto)
        {
            if (objeto is not null) 
            {
                EjecutarNonQuery($"UPDATE componentes SET nombre = '{objeto.Nombre}', marca = '{objeto.Marca}', Color_id = '{Convert.ToInt32(objeto.Color)}', stock = '{Convert.ToString(objeto.Stock)}', precio = '{Convert.ToString(objeto.Precio)}', descripcion = '{objeto.DescripcionProducto}',TipoDeProducto_id = '{Convert.ToInt32(objeto.TipoProducto)}' ,rgb = '{Convert.ToString(objeto.Rgb)}' WHERE id = '{objeto.Id}'");
            }
            
        }

        public List<Componente> TraerAsync()
        {
            var comps = new List<Componente>();

            try
            {
                 var dataTable = EjecutarQuery("SELECT * FROM componentes");

                 foreach (DataRow item in dataTable.Rows)
                 {
                     var id = Convert.ToInt32(item["id"]);
                     string nombre = item["nombre"].ToString().Trim();
                     string marca = item["marca"].ToString().Trim();
                     Color color = (Color)Convert.ToInt32(item["Color_id"]);
                     int stock = Convert.ToInt32(item["stock"]);                
                     var precio = Convert.ToInt32(item["precio"]);              
                     string descripcion = item["descripcion"].ToString().Trim();
                     TipoDeComponente producto = (TipoDeComponente)Convert.ToInt32(item["TipoDeProducto_id"]);
                     string rgb = item["rgb"].ToString().Trim();

                     bool Rgb = false;
                     if (rgb.ToLower() == "true")
                         Rgb = true;

                     comps.Add(new(id,producto,nombre,marca,Rgb, precio, descripcion,stock,color));
                 }
            }
            catch (Exception ex) 
            {
                new Exception("error al conectarse a la base de datos");
                Ticket.GeneradorDeErrores(ex.Message, "public List<Cliente> TraerAsync()");
            }
             

            return comps;
        }

        public Componente TraerAsync(int id)
        {
            var lista = TraerAsync();

            foreach (var item in lista)
            {
                if (item.Id == id)
                {

                    return item;
                }
            }
            throw new Exception("No se encontro un componente con esa id");
        }
    }
}
