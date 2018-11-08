using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace sistematutor.Models
{
    public class curso
    {
        [Key]
        public int id_curso { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El Nombre del curso debe tener de 10 a 95 caracterés")]
        public string nombre_curso { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El Nivel del curso debe tener de 3 a 45 caracterés")]
        public string nivel { get; set; }
    }
}
