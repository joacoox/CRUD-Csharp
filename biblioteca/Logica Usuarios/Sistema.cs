using biblioteca.Archivos;
using biblioteca.Base_de_datos_SQL;
using biblioteca.Logica_Usuarios;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace biblioteca
{
    public class Sistema : IAdminsitrable<User>
    {
     
      

        public bool Agregar(User objeto)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int id)
        {
                    
            UserGN userDataBase = new();
            userDataBase.Borrar(id);
                   
        }

        public User GetObjeto(int id)
        {
            foreach (var item in GetLista())
            {
                if (item.Id == id)
                {
                    if (item is Admin)
                    {
                        return (Admin)item;
                    }
                    return item;
                }
            }
            throw new Exception($"No se encontro ningun usuario o cliente con esa id{id}");
        }

        public void Editar(User objeto)
        {
            if (objeto is not null)
            {
                UserGN userDataBase = new();
                userDataBase.Editar(objeto);
            }
        }




        /// <summary>
        /// Verifica si un usuario esta en la lista
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="contra"></param>
        /// <returns>true si esta en la lista, false si no</returns>


        public static List<User> GetLista()
        {
            UserGN user = new();
            List<User> listaUsuarios = user.TraerAsync();

            return listaUsuarios;
        }


        public static bool EstaRegistrado(string nombreUsuario, Func<List<User>> obtenerLista)
        {
            List<User> lista = obtenerLista();

            foreach (var item in lista)
            {
                if (item.Nombre == nombreUsuario)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Intenta agregar un usuario a la lista si es que ya no esta incluido
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="contra"></param>
        /// <param name="esAdmin"></param>
        /// <returns>true si pudo false si no</returns>
        public static bool Registrar(string nombreUsuario, string contra, bool admin)
        {        
            UserGN user = new();

            if (!EstaRegistrado(nombreUsuario, () => GetLista()))
            {
                if (admin)
                {
                    user.AgregarAsync(new Admin(nombreUsuario, contra, true));
                }
                else
                {
                    user.AgregarAsync(new User(nombreUsuario, contra));
                }
                return true;
            }
            return false;
        }
     
        /// <summary>
        /// Busca un usuario en la base de datos que concuerde con el nombre y la contra
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="contra"></param>
        /// <returns>un usuario que cumla con los parametros</returns>
        public static User getUsuario(string nombreUsuario)
        {

            foreach (var item in GetLista())
            {
                if (item.Nombre == nombreUsuario)
                {
                    if (item is Admin)
                    {
                        return (Admin)item;
                    }
                    return item;
                }
            }
            throw new Exception($"No se encontro ningun usuario con ese nombre {nombreUsuario}");
        }

        /*  public static User getUsuario(int id)
           {

               foreach (var item in GetLista())
               {
                   if (item.Id == id)
                   {
                       if (item is Admin)
                       {
                           return (Admin)item;
                       }
                       return item;
                   }
               }
               throw new Exception($"No se encontro ningun usuario o cliente con esa id{id}");
           }*/
        /// <summary>
        /// recibe un usuario y si es igual lo elimina
        /// </summary>
        /// <param name="user"></param>
        /// <returns>true si pudo false si no</returns>
        public static bool EliminarUser(User user)
        {
            bool result = false;

            foreach (User usuario in GetLista())
            {
                if (usuario == user)
                {
                    UserGN userDataBase = new();
                    userDataBase.Borrar(user.Id);
                    result = true;
                    break;
                }
            }
            return result;
        }
        public static bool EliminarUser(int id)
        {
            bool result = false;

            foreach (User usuario in GetLista())
            {
                if (usuario.Id == id)
                {
                    UserGN userDataBase = new();
                    userDataBase.Borrar(id);
                    result = true;
                    break;
                }
            }
            return result;
        }/*
        public static void EditarUser(User user)
        {
            if (user is not null)
            {
                UserGN userDataBase = new();
                userDataBase.Editar(user);
            }
        }*/

        public static void CrearCliente(Cliente cliente) 
        {
            ClienteGN listaCliente = new();                          
            listaCliente.AgregarAsync(cliente);                                     
        }

        public static Cliente GetCliente(int id) 
        {
            ClienteGN listaCliente = new();
            var cliente  = listaCliente.TraerAsync(id);
            return cliente;
        }

        public static void EditarCliente(Cliente objeto) 
        {
            ClienteGN listaCliente = new();
            listaCliente.Editar(objeto);
        }    
        public static int DevolverCantidadPorParametros(Predicate<User> condicion)
        {
            int contador = 0;
            foreach (User usuario in GetLista())
            {
                if (condicion(usuario))
                {
                    contador++;
                }
            }

            return contador;
        }
       
    }
}
