using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ApiMiTesisUG.Entities.Interfaces;
using Newtonsoft.Json;

namespace ApiMiTesisUG.Entities
{
    [Table("Usuarios")]
    public class Usuarios 
    {
        [Key]
        [Column("Id")]
        [JsonProperty("id")]
        public int Id { get; set; }

        [Column("Nombre")]
        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [Column("Correo")]
        [JsonProperty("correo")]
        public string Correo { get; set; }

        [Column("Usuario")]
        [JsonProperty("usuario")]
        public string Usuario { get; set; }

        [Column("Clave")]
        [JsonProperty("clave")]
        public string Clave { get; set; }


        [JsonProperty("roles")]
        public List<Roles> Roles {  get; set; }

        [JsonProperty("carreras")]
        public List<Carreras> Carreras { get; set; }

                
    }


    public class Carreras
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("idFacultad")]
        public int IdFacultad { get; set; }

        [JsonProperty("nombre")]
        public string Nombre { get; set; }
    }

    public class Roles
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("nombre")]
        public string Nombre { get; set; }
    }

}