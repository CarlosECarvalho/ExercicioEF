using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Api.Database
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options) : base(options) 
        { 
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<EnderecoEntrega> EnderecosEntrega { get; set; }
        public DbSet<Departamento> Departamentos { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Departamento>().HasData(
                new Departamento { Id = 1, Nome = "Vendas" },
                new Departamento { Id = 2, Nome = "Compras" },
                new Departamento { Id = 3, Nome = "Logistica" },
                new Departamento { Id = 4, Nome = "TI" },
                new Departamento { Id = 5, Nome = "RH" },
                new Departamento { Id = 6, Nome = "Produção" },
                new Departamento { Id = 7, Nome = "Financeiro" },
                new Departamento { Id = 8, Nome = "Marketing" },
                new Departamento { Id = 9, Nome = "Juridico" },
                new Departamento { Id = 10, Nome = "Qualidade" },
                new Departamento { Id = 11, Nome = "Manutenção" },
                new Departamento { Id = 12, Nome = "Segurança" },
                new Departamento { Id = 13, Nome = "Engenharia" },
                new Departamento { Id = 14, Nome = "Administração" }
                );
        } //executo uma inserção de dados no banco de dados, como uma carga inicial de dados padrão

        #region Conexao sem distinção de ambiente
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=PC-CADU\\SQLEXPRESS;Initial Catalog=EcommerEF ;Integrated Security=True");
        //    base.OnConfiguring(optionsBuilder);


        //}
        #endregion

    }
}
