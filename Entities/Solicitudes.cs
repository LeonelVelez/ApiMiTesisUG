using ApiMiTesisUG.Entities.Interfaces;

namespace ApiMiTesisUG.Entities
{
    public class Solicitudes
    {
        public int Id {get; set;}        
        public IUsuario Estudiante {get; set;}     
        public IUsuario Profesor {get; set;}     
        public int Estado {get; set;}     
    }
}