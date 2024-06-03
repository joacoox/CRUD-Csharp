using biblioteca.Archivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class ConfiguracionInicio
    {
        public int IdUsuario { get; set; }
        public bool BaseDatosSql { get; set; }
        public bool BaseDatosFireBase { get; set; }
        public bool GeneradorAutomaticoDeVentas { get; set; }
        public ConfiguracionInicio()
        {
          
        }
        public ConfiguracionInicio(int id, bool baseDatosSql, bool baseDatosFireBase, bool generadorAutomaticoDeVentas)
        {
            IdUsuario = id;
            BaseDatosSql = baseDatosSql;
            BaseDatosFireBase = baseDatosFireBase;
            GeneradorAutomaticoDeVentas = generadorAutomaticoDeVentas;
        }

        public static void SerializarConfiguracion(ConfiguracionInicio config) 
        {
            SerializadoraJSON<ConfiguracionInicio> json = new();       
            json.Escribir(config, config.IdUsuario.ToString());
        }
       
    }
}
