using ApiMiTesisUG.Entities.Interfaces;

namespace ApiMiTesisUG.Entities
{
    public class HttpErrorResponse : IHttpOption
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
    }
}