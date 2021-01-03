using System.Collections.Generic;

namespace ApiMiTesisUG.Entities.Interfaces
{
    public interface IUsuario
    {
        public int Id {get;set;}
        public string Nombre {get;set;}
        public string Correo {get;set;}
        public string Usuario {get;set;}
        public string Clave {get;set;}

        public List<ICarreras> Carreras {get; set;}
        public List<IRoles> Roles {get; set;}
    }

    public interface ICarreras
    {
        public int Id {get;set;}
        public int IdFacultad {get;set;}
        public string Nombre {get;set;}
    }

    public interface IRoles
    {
        public int Id {get;set;}        
        public string Nombre {get;set;}
    }

    
}