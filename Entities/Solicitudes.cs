using ApiMiTesisUG.Entities.Interfaces;

namespace ApiMiTesisUG.Entities
{
    public class Solicitudes: IHttpOption
    {
        public int Id {get; set;}        
        public Usuarios Estudiante {get; set;}     
        public Usuarios Profesor {get; set;}     
        public int Estado {get; set;}     
    }
}