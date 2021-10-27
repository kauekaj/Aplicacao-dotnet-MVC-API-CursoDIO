using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoDioMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Category> Categorias { get; set; }
        public DbSet<Product> Produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=Cursodiomvc;Trusted_Connection=True;");
        }
    }
}
