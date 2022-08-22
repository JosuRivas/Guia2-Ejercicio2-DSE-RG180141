using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Persona.Models
{
    public class Persona
    {
        [Key]
        public string DUI { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode
= true)]
        public DateTime fechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string correo { get; set; }


    }

    public class PersonaDBContext : DbContext
    { 
        public DbSet<Persona> Personas { get; set; }
    
    }
}