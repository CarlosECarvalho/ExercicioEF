﻿// <auto-generated />
using System;
using Ecommerce.Api.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ecommerce.Api.Migrations
{
    [DbContext(typeof(EcommerceContext))]
    partial class EcommerceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DepartamentoUsuario", b =>
                {
                    b.Property<int>("DepartamentosId")
                        .HasColumnType("int");

                    b.Property<int>("UsuariosId")
                        .HasColumnType("int");

                    b.HasKey("DepartamentosId", "UsuariosId");

                    b.HasIndex("UsuariosId");

                    b.ToTable("DepartamentoUsuario");
                });

            modelBuilder.Entity("Ecommerce.models.Contato", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UsuarioID")
                        .IsUnique();

                    b.ToTable("Contatos");
                });

            modelBuilder.Entity("Ecommerce.models.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departamentos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Vendas"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Compras"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Logistica"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "TI"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "RH"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "Produção"
                        },
                        new
                        {
                            Id = 7,
                            Nome = "Financeiro"
                        },
                        new
                        {
                            Id = 8,
                            Nome = "Marketing"
                        },
                        new
                        {
                            Id = 9,
                            Nome = "Juridico"
                        },
                        new
                        {
                            Id = 10,
                            Nome = "Qualidade"
                        },
                        new
                        {
                            Id = 11,
                            Nome = "Manutenção"
                        },
                        new
                        {
                            Id = 12,
                            Nome = "Segurança"
                        },
                        new
                        {
                            Id = 13,
                            Nome = "Engenharia"
                        },
                        new
                        {
                            Id = 14,
                            Nome = "Administração"
                        });
                });

            modelBuilder.Entity("Ecommerce.models.EnderecoEntrega", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeEndereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioID");

                    b.ToTable("EnderecosEntrega");
                });

            modelBuilder.Entity("Ecommerce.models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("DataCadastro")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeMae")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomePai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SituacaoCadastro")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("DepartamentoUsuario", b =>
                {
                    b.HasOne("Ecommerce.models.Departamento", null)
                        .WithMany()
                        .HasForeignKey("DepartamentosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UsuariosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ecommerce.models.Contato", b =>
                {
                    b.HasOne("Ecommerce.models.Usuario", "Usuario")
                        .WithOne("Contato")
                        .HasForeignKey("Ecommerce.models.Contato", "UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Ecommerce.models.EnderecoEntrega", b =>
                {
                    b.HasOne("Ecommerce.models.Usuario", "Usuario")
                        .WithMany("EnderecosEntregas")
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Ecommerce.models.Usuario", b =>
                {
                    b.Navigation("Contato");

                    b.Navigation("EnderecosEntregas");
                });
#pragma warning restore 612, 618
        }
    }
}
