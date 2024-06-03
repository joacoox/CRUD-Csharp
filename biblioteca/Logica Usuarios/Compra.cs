using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace biblioteca
{
    [Serializable]
    public class Compra
    {
        int id;
        public int cantidad;
        DateTime fecha;
        public Compra()
        {
            
        }
        public Compra(int cantidad, DateTime fecha)
        {
            Cantidad = cantidad;
            Fecha = fecha;
        }
        public Compra(int id, int cantidad, DateTime fecha) : this(cantidad,fecha) 
        {
            this.id = id;
        }
        [XmlElement("Id")]
        public int Id { get => id; set => id = value; }

        [XmlElement("Cantidad")]
        public int Cantidad { get => cantidad; set => cantidad = value; }

        [XmlElement("Fecha")]
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
