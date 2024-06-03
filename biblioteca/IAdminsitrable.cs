using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    internal interface IAdminsitrable<T>
    {        
        public bool Agregar(T objeto);
        public void Borrar(int id);
        public T GetObjeto(int id);
        public void Editar(T objeto);
    }
}
