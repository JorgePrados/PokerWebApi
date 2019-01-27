using Microsoft.EntityFrameworkCore;
using Models.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }

        public DbSet<Cliente> Clientes { get;set; }
        public DbSet<Carta> Cartas { get; set; }
        public DbSet<Jugada> Jugadas { get; set; }
        public DbSet<ManoInicial> ManosIniciales { get; set; }

    }
}
