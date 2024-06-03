using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca.Archivos
{
    public interface ISerializable<T> where T : class
    {
        public void Escribir(T info, string archivo);

        public T Leer(string archivo);
    }
}
