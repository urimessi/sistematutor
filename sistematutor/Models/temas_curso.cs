using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace sistematutor.Models
{
    public class temas_curso
    {
        [Key]
        public int id_tema { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El Nombre del tema debe tener de 10 a 95 caracterés")]
        public string nombre_tema { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El curso debe tener de 3 a 45 caracterés")]
        public string id_curso { get; set; }
    }
}
