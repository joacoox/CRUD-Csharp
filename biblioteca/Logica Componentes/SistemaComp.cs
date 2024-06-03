using biblioteca.Archivos;
using biblioteca.Base_de_datos_SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class SistemaComp : IAdminsitrable<Componente>
    {
        

    

        public bool Agregar(Componente objeto)
        {
            ComponenteGN gn = new();

            if (!EstaEnLaLista(objeto))
            {
                gn.AgregarAsync(objeto);
                return true;
            }
            return false;
        }

        public void Borrar(int id)
        {
            ComponenteGN gn = new();
            gn.Borrar(id);
        }

        public Componente GetObjeto(int id)
        {
            ComponenteGN gn = new();

            foreach (Componente item in gn.TraerAsync())
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            throw new Exception($"No se encontro el componente con esa id: {id}");
        }

        public void Editar(Componente objeto)
        {
            ComponenteGN gn = new();
            gn.Editar(objeto);
        }
        /// <summary>
        /// retorna la lista
        /// </summary>
        /// <returns></returns>
        public static List<Componente> GetLista()
        {
            ComponenteGN comp = new();
            return comp.TraerAsync();
        }
    /*    /// <summary>
        /// Agrega un componente a la lista 
        /// </summary>
        /// <param name="componente"></param>
        /// <returns>true si pudo, false si no</returns>
        public static bool AgregarComponente(Componente componente)
        {
            ComponenteGN gn = new();

            if (!EstaEnLaLista(componente))
            {
                gn.AgregarAsync(componente);
                return true;
            }
            return false;
        }*/
        /// <summary>
        /// se fija si el componente esta en la lista
        /// </summary>
        /// <param name="componente"></param>
        /// <returns>true si pudo false si no</returns>
        public static bool EstaEnLaLista(Componente componente)
        {
            ComponenteGN gn = new();

            foreach (Componente obj in gn.TraerAsync())
            {
                if (obj == componente)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// busca un componente en la lista
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="nombre"></param>
        /// <param name="marca"></param>
        /// <returns>si encuentra el objeto lo retorna, de lo contrario devuelve null</returns>
        public static Componente GetComponente(TipoDeComponente tipo, string nombre, string marca)
        {
            ComponenteGN gn = new();

            foreach (Componente item in gn.TraerAsync())
            {
                if (item.TipoProducto == tipo && item.Nombre == nombre && item.Marca == marca)
                {
                    return item;
                }
            }
            throw new Exception($"No se encontro el componente con ese nombre {nombre}");          
        }/*
        public static Componente GetComponente(int id)
        {
            ComponenteGN gn = new();

            foreach (Componente item in gn.TraerAsync())
            {
                if (item.Id == id)
                {
                    return item;
                }
            }         
            throw new Exception($"No se encontro el componente con esa id: {id}");
        }
        /// <summary>
        /// recibe un componente si lo encuentra lo saca de la lista
        /// </summary>
        /// <param name="item"></param>
        /// <returns>true si pudo false si no</returns>
        public static void EliminarComponente(Componente item)
        {
          
            ComponenteGN gn = new();
            gn.Borrar(item.Id);
            
        }
        /// <summary>
        /// recibe un componente
        /// </summary>
        /// <param name="componente"></param>
        /// <param name="stockAEliminar"></param>
        public static void Editar(Componente componente)
        {
            ComponenteGN gn = new();
            gn.Editar(componente);
        }*/
        /// <summary>
        /// devuelve una lista con los componentes que tengan bajo stocks
        /// </summary>
        /// <returns></returns>
        public static List<Componente> ComponentesEnBajoStock() 
        {
            List<Componente> lista = new List<Componente>();
            ComponenteGN comp = new();

            foreach (Componente item in comp.TraerAsync())
            {
                if (item.Stock <= 5) 
                {
                    lista.Add(item);
                }
            }
        return lista;
        }
       
    }
}
