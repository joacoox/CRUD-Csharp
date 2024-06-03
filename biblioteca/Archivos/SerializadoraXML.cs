using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.Runtime.CompilerServices;

namespace biblioteca.Archivos
{
   
    public class SerializadorXML<T> : ISerializable<T> where T : class
    {
        public string ruta;

        public SerializadorXML()
        {
            ruta = Environment.CurrentDirectory;
            ruta += @"/Archivos/";
        }

        public void Escribir(T info, string archivo)
        {
          
        }   
        public T Leer(string archivo)
        {
            return null;
        }

        public void EscribirVentas(List<T> lista, string archivo)
        {
            string rutaCompleta = ruta + archivo + ".xml";

            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }

            using (XmlTextWriter writer = new XmlTextWriter(rutaCompleta, Encoding.UTF8))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
                xmlSerializer.Serialize(writer, lista);
            }
        }
        public List<T> LeerVentas(string archivo)
        {
            List<T> lista = null;
            string rutaCompleta = ruta + archivo + ".xml";

            if (Directory.Exists(ruta))
            {
                using (XmlTextReader reader = new XmlTextReader(rutaCompleta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
                    lista = (List<T>)xmlSerializer.Deserialize(reader);
                }
            }
            else
            {
                throw new Exception("No existe el archivo");
            }
            return lista;
        }
    }
}
