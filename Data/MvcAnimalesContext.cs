using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FormularioHolaMundo.Models;

namespace FormularioHolaMundo.Data
{
    public class MvcAnimalesContext : DbContext
    {
        public MvcAnimalesContext (DbContextOptions<MvcAnimalesContext> options)
            : base(options)
        {
        }

        public DbSet<FormularioHolaMundo.Models.Animal> Animal { get; set; }
    }
}
