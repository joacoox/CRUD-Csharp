using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace biblioteca
{
    [Serializable]
    public abstract class Producto
    {
        int id;
        string nombre;
        string marca;
        Color color;
        int stock;
        float precio;
        string descripcionProducto;
        public Producto() { }
        public Producto(string nombre, string marca, Color color, float precio, string descripcionProducto, int stock)
        {
            Id = id;
            Nombre = nombre;
            Marca = marca;
            Color = color;
            Stock = stock;
            Precio = precio;
            DescripcionProducto = descripcionProducto;
        }
        public Producto(int id ,string nombre, string marca, Color color ,float precio, string descripcionProducto, int stock)
        {
            Id = id;
            Nombre = nombre;
            Marca = marca;
            Color = color;
            Stock = stock;
            Precio = precio;
            DescripcionProducto = descripcionProducto;
        }
        [XmlElement("Nombre")]
        public string Nombre { get => nombre; set => nombre = value; }
        [XmlElement("Marca")]
        public string Marca { get => marca; set => marca = value; }
        [XmlElement("Color")]
        public Color Color { get => color; set => color = value; }
        [XmlElement("Stock")]
        public int Stock { get => stock; set => stock = value; }
        [XmlElement("Precio")]
        public float Precio { get => precio; set => precio = value; }
        [XmlElement("DescripcionProducto")]
        public string DescripcionProducto { get => descripcionProducto; set => descripcionProducto = value; }
        [XmlElement("Id")]
        public int Id { get => id; set => id = value; }
    }

}

