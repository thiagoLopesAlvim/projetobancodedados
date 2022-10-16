using Microsoft.EntityFrameworkCore;
using projetobancodedados.Models;
using System.Security.Cryptography.X509Certificates;

namespace projetobancodedados.Data
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
       { }

        public DbSet<Usuarios> Usuarios { get; set; }

        public DbSet<Vendas> Vendas { get; set; }

        public DbSet<Clientes> Clientes { get; set; }
    }
}
