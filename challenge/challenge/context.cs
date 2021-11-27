using challenge;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


public class Context : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("");
    }
    public DbSet<Personaje> Personajes { get; set; }
    public DbSet<PeliculaSerie> PeliculaSeries { get; set; }
    public DbSet<Genero> Generos { get; set; }



}
