using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

namespace biblioteca
{

    [Serializable]
    public class User
    {
        int id;
        string nombre;
        string contraseña;

        public User()
        {
           
        }
        public User(string nombre, string contraseña)
        {
            this.nombre = nombre;
            this.contraseña = contraseña;
        }
        public User(int id, string nombre, string contraseña) : this(nombre, contraseña)
        {
            this.id = id;
        }
        [XmlElement("Id")]
        public int Id { get => id; set => id = value; }
        [XmlElement("Nombre")]
        public string Nombre { get => nombre; set => nombre = value; }
        [XmlElement("Contraseña")]
        public string Contraseña { get => contraseña; set => contraseña = value; }

      /// <summary>
      ///  compara dos usuarios
      /// </summary>
      /// <param name="a"></param>
      /// <param name="b"></param>
      /// <returns>si son iguales retorna true, de lo contrario false</returns>
        public static bool operator == (User a, User b)
        {           
            return a.nombre == b.nombre;
        }
        /// <summary>
        ///  compara dos usuarios
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>si son iguales retorna false, de lo contrario true</returns>
        public static bool operator != (User a, User b)
        {
            return !(a == b);
        }

       
    }
}