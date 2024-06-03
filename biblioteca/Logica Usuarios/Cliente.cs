using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca.Logica_Usuarios
{
    public class Cliente : User
    {
         DatosParaPagar datos;

        public Cliente(DatosParaPagar datos, string nombre, string contra) : base (nombre, contra)
        {
            this.datos = datos;
        }
        public Cliente(DatosParaPagar datos, int id,string nombre, string contra) : base(id,nombre, contra)
        {
            this.datos = datos;
        }
        public DatosParaPagar Datos { get => datos; set => datos = value; }

    }
}
