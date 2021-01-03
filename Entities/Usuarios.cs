using System.Collections.Generic;
using ApiMiTesisUG.Entities.Interfaces;

namespace ApiMiTesisUG.Entities
{
    public class Usuarios : IUsuario
    {
        public int Id {  get; set; }
        public string Nombre {   get; set;}
        public string Correo { get; set;  }
        public string Clave {  get; set; }
        public List<ICarreras> Carreras {   get; set;}
        public List<IRoles> Roles {  get; set; }
        public string Usuario {  get; set; }
    }

}