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
    public class UserGN : Consulta, IModificable<User>
    {
        public UserGN() : base("Server=.;Database=usuarios;Trusted_Connection=True;") { }

        public void AgregarAsync(User objeto)
        {
            if (objeto is not null) 
            { 
                if (objeto is Admin)
                {
                    EjecutarNonQuery($"INSERT INTO usuarios (nombre, contraseña, admin) VALUES ('{objeto.Nombre}', '{objeto.Contraseña}', 'si')");
                }
                else 
                {
                    EjecutarNonQuery($"INSERT INTO usuarios (nombre, contraseña, admin) VALUES ('{objeto.Nombre}', '{objeto.Contraseña}', 'no')");
                }
            }
            
           
        }

        public void Borrar(int id)
        {
            if (id >= 0) 
            {
                EjecutarNonQuery($"DELETE FROM usuarios WHERE id = {id}");
            }
          
        }

        public void Editar(User objeto)
        {
            if (objeto is not null) 
            {
                if (objeto is Admin)
                {
                    EjecutarNonQuery($"UPDATE usuarios SET nombre = '{objeto.Nombre}', contraseña = '{objeto.Contraseña}', admin = 'si'  WHERE id = '{objeto.Id}'");
                }
                else 
                {
                    EjecutarNonQuery($"UPDATE usuarios SET nombre = '{objeto.Nombre}', contraseña = '{objeto.Contraseña}', admin = 'no' WHERE id = '{objeto.Id}'");
                }
               
            }
          
        }

        public List<User> TraerAsync()
        {
            var usuarios = new List<User>();

            try 
            { 
                var dataTable = EjecutarQuery("SELECT * FROM usuarios");

                foreach (DataRow item in dataTable.Rows)
                {
                    var id = Convert.ToInt32(item["id"]);
                    string nombre = item["nombre"].ToString().Trim();
                    string apellido = item["contraseña"].ToString().Trim();
                    string admin = item["admin"].ToString().Trim();

                    if (admin == "si")
                    {
                        usuarios.Add(new Admin(id, nombre, apellido,true));
                    }
                    else 
                    {
                        usuarios.Add(new(id, nombre, apellido));
                    }              
                }                    
            }
            catch (Exception ex) 
            {
                new Exception("error al conectarse a la base de datos");
                Ticket.GeneradorDeErrores(ex.Message, "public List<User> TraerAsync()");
            }
           return usuarios;
        }

        public User TraerAsync(int id)
        {
            var lista = TraerAsync();

            foreach (var item in lista)
            {
                if (item.Id == id)
                {            
                    if(item is Admin) 
                    { 
                        return (Admin)item;
                    }
                    return item;
                }
            }
            throw new Exception("No se encontro un usuario con esa id");
        }
    }
}
