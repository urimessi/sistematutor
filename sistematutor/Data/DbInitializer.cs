using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistematutor.Models;

namespace sistematutor.Data
{
    public class DbInitializer
    {
        public static void Initialize(sistematutorContext context)
        {
            context.Database.EnsureCreated();
            if (context.temas_curso.Any())
            {
                return;
            }
            var temas_curso = new temas_curso[]
            {
                //
            };
            foreach (temas_curso a in temas_curso)
            {
                context.temas_curso.Add(a);
            }
            context.SaveChanges();
        
        }
    }
}
