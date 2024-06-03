using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace biblioteca
{
    [Serializable]
    public class CompraUsuario : Compra
    {
     
        private User usuario;    
        private Componente componente;
        public CompraUsuario()
        {
            
        }
        public CompraUsuario(Componente componente, int cantidad,DateTime tiempo ,User usuario) : base(cantidad,tiempo) 
        {
            Usuario = usuario;
            this.Componente = componente;
        }
        public CompraUsuario(int id ,Componente componente, int cantidad, DateTime tiempo, User usuario) : base(id ,cantidad, tiempo)
        {
            this.Id = id;
            Usuario = usuario;
            this.Componente = componente;
        }
        [XmlElement("Usuario")]
        public User Usuario { get => usuario; set => usuario = value; }
        [XmlElement("Componente")]
        public Componente Componente { get => componente; set => componente = value; }


        

    }
}
