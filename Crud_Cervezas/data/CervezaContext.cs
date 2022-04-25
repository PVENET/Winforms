    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.EntityFrameworkCore;

    namespace Crud_Cervezas
    {
        public class CervezasContext : DbContext
        {
            public DbSet<Cerveza> Cervezas { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            { 
                optionsBuilder.UseSqlServer(@"Server=(LocalDB)\PVE;Database=Cervezas;Trusted_Connection=True;");
            }

        }
    }