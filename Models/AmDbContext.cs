using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ActivityManagement.Services;
using Microsoft.EntityFrameworkCore;

namespace ActivityManagement.Models
{
    public class AmDbContext : DbContext
    {
        public AmDbContext (DbContextOptions<AmDbContext> options) : base (options)
        {

        }
        public DbSet<Obra> Obra { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<ViewPainelProjetos> VwProjetos { get; set; }
    }
}