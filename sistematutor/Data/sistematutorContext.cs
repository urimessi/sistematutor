using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using sistematutor.Models;

namespace sistematutor.Models
{
    public class sistematutorContext : DbContext
    {
        public sistematutorContext (DbContextOptions<sistematutorContext> options)
            : base(options)
        {
        }

        public DbSet<sistematutor.Models.temas_curso> temas_curso { get; set; }

        public DbSet<sistematutor.Models.curso> curso { get; set; }
    }
}
