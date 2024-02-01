using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Ecommerce.Api.Database
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<EnderecoEntrega> EnderecosEntrega { get; set; }
        public DbSet<Departamento> Departamentos { get; set;}

        #region Conexao sem distinção de ambiente
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=PC-CADU\\SQLEXPRESS;Initial Catalog=EcommerEF ;Integrated Security=True");
        //    base.OnConfiguring(optionsBuilder);


        //}
        #endregion

    }
}
