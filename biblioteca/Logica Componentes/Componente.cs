using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace biblioteca
{
    [Serializable]
    public class Componente : Producto
    {
        TipoDeComponente tipoProducto;
        bool rgb;

        public Componente() { }
        public Componente(TipoDeComponente producto, string nombre, string marca, bool rgb, float precio, string descripcionProducto, int stock, Color color) : base(nombre, marca, color, precio, descripcionProducto, stock)
        {
            this.TipoProducto = producto;
            this.Rgb = rgb;

        }
        public Componente(int id, TipoDeComponente producto, string nombre, string marca, bool rgb, float precio, string descripcionProducto, int stock, Color color) : base(id,nombre,marca,color,precio,descripcionProducto,stock)
        {
            Id = id;
            this.TipoProducto = producto;
            this.Rgb = rgb;
        
        }
        [XmlElement("TipoProducto")]
        public TipoDeComponente TipoProducto { get => tipoProducto; set => tipoProducto = value; }
        [XmlElement("Rgb")]
        public bool Rgb { get => rgb; set => rgb = value; }

        /// <summary>
        /// Comparo dos componentes
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>true si son iguales false si no</returns>
        public static bool operator ==(Componente a, Componente b)
        {
            return a.tipoProducto == b.tipoProducto && a.Nombre == b.Nombre && a.Marca == b.Marca;
        }
        /// <summary>
        /// Comparo dos componentes
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>true si son distintos false si son iguales</returns>
        public static bool operator !=(Componente a, Componente b)
        {
            return !(a == b);
        }

    }
}
