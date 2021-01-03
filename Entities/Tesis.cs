using ApiMiTesisUG.Entities.Interfaces;

namespace ApiMiTesisUG.Entities
{
    public class Tesis
    {
        public int Id {get;set;}
        public IUsuario Usuario {get;set;}
        public ICarreras Carrera {get;set;}

        public string Titulo {get;set;}
        public string Area {get;set;}
        public string Descripcion {get;set;}
    }
}