using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace biblioteca.Archivos
{
    public class SerializadoraJSON<T> : ISerializable<T> where T : class
    {
        static string ruta;

        static SerializadoraJSON()
        {
            ruta = Environment.CurrentDirectory;
            ruta += @"/Archivos/";
        }

        public void Escribir(T objeto, string archivo)
        {
            string rutaCompleta = ruta + archivo + ".json";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }              
                string json = JsonSerializer.Serialize(objeto);

                File.WriteAllText(rutaCompleta, json);
            }
            catch (Exception ex)
            {
                Ticket.GeneradorDeErrores(ex.Message, "public void Escribir(T objeto, string archivo)");
            }
        }  
        public T Leer(string archivo)
        {
            
            string rutaCompleta = ruta + archivo + ".json";

            try
            {               
                if (File.Exists(rutaCompleta))
                {
                    string json = File.ReadAllText(rutaCompleta);
                    var objeto = JsonSerializer.Deserialize<T>(json);
                    return objeto;
                }               
            }
            catch (Exception)
            {
                throw;
            }

            return null;
        }
    }
}