using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca.Logica_Usuarios
{
    public class Admin : User
    {
       bool permisos;

        public Admin(string nombre, string contra, bool permisos) : base (nombre,  contra)
        {
            Permisos = permisos;
        }
        public Admin(int id, string nombre, string contra, bool permisos) : base(id, nombre, contra)
        {
            Permisos = permisos;
        }
        public bool Permisos { get => permisos; set => permisos = value; }
    }

}
