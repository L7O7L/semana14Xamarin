using Microsoft.EntityFrameworkCore;
using semana14.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace semana14.DataContext
{
    public class AppDbContext: DbContext
    {

        //Path donde se va guardar la base de datos
        string DbPath = string.Empty;


        //Tablas de base de datos
        public DbSet<Product> Product { get; set; }



        //Estándar del desarrollo con EFC
        public AppDbContext(string dbPath)
        {
            this.DbPath = dbPath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DbPath}");
        }

    }
}
