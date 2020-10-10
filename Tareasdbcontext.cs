using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Parcial1
{
    class Tareasdbcontext : DbContext
    {
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=tareas.db");
        }
   
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>()
                .ToTable("Usuarios")
                .Property(prop => prop.Clave);
            modelBuilder.Entity<Detalles>()
                .ToTable("Detalles");
            


            modelBuilder.Entity<Recursos>()
                .ToTable("Recursos");


            modelBuilder.Entity<Tareas>()
                .ToTable("Tareas");


        }

        public DbSet<Usuarios> Usuarios { get; set; }


    }
}
