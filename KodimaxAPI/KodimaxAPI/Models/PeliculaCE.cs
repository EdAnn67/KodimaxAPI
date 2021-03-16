using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KodimaxAPI.Models
{
    public class PeliculaCE
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public System.TimeSpan Duracion { get; set; }
        [Required]
        public int Genero { get; set; }
        [Required]
        public string Imagen { get; set; }

        public virtual Genero Genero1 { get; set; }
    }
}