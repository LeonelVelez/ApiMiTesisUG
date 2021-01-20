using Newtonsoft.Json;
using System.Collections.Generic;

namespace ApiMiTesisUG.Entities.Interfaces
{
    public interface IUsuario
    {

        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Correo { get; set; }

        public string Usuario { get; set; }
        public string Clave {get;set;}

    }


    
}