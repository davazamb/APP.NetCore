using Entidades.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class GaleriaDbContext : DbContext
    {
        public GaleriaDbContext(DbContextOptions<GaleriaDbContext>options) : base(options)
        {                                                                                   

        }
        public DbSet<Album> Album { get; set; } 
    }
}
