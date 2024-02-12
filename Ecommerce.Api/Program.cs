global using Ecommerce.models;
using Ecommerce.Api.Database;
using Ecommerce.Api.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //var configuration = builder.Configuration; //essa configura��o servir� para o controle de banco de dados

            #region ConfigureService()
            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IUsuarioRepository,UsuarioRepository>(); //adiciono a forma de gerenciamento do ciclo de vida da instancia��o no conteiner de inje��o
            //permite que eu altere a instancia��o apenas trocando a classe concreta que ser� instanciada, podendo fazer a troca de banco de dados, ou para um moq de testes

            builder.Services.AddDbContext<EcommerceContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Ecommerce"))
            );//implemento o context do meu db ao projeto, com a express�o lambda indico a vari�vel configuration com a propriedade GetConnection indico o nome da propriedade do banco no Json

            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
