using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLazyLoadingDemo
    {

    public class AppDbContext : DbContext
        {

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {

            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=DESKTOP-CGLP4AL\\SQLEXPRESS;Database=LazyLoadingDemo;Trusted_Connection=True;TrustServerCertificate=True;");
            }


        }
    }