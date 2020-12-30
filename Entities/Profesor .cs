using System.Collections.Generic;

namespace ApiMiTesisUG.Entities
{
    public class Profesor 
    {
        public int Id {get;set;}
        public string Nombre {get;set;}
        public string Correo {get;set;}
        public List<Carreras> Carreras {get; set;}
    }

    public class Carreras
    {
        public int Id {get;set;}
        public string Nombre {get;set;}
        public string Correo {get;set;}
    }

}