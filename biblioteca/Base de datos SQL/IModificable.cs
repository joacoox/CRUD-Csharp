using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca.Base_de_datos_SQL
{
    public interface IModificable<T>
    {
        public List<T> TraerAsync();
        public T TraerAsync(int id);
        public void Borrar(int id);
        public void AgregarAsync(T objeto);
        public void Editar(T objeto);
    }
}
