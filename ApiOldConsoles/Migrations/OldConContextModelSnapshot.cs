﻿// <auto-generated />
using System;
using ApiOldConsoles.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiOldConsoles.Migrations
{
    [DbContext(typeof(OldConContext))]
    partial class OldConContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ApiOldConsoles.Models.OldConsole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Ano")
                        .HasColumnType("int");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Compatibilidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Condicao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fabricante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Regiao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Valor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OldConsoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ano = 1989,
                            Categoria = "Video game",
                            Compatibilidade = "PC Engine",
                            Condicao = "Semi-Novo",
                            Descricao = "TurboGrafx-16, conhecido no Japão como PC Engine, é um console de videogame lançado em 1987 pela NEC e Hudson Soft. Após seu lançamento no Japão e sua aceitação nesse país, foi lançado em 1989 nos Estados Unidos batizado de Turbo Grafx-16",
                            Fabricante = "NEC Corporation",
                            Foto = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d0/TurboGrafx16-Console-Set.jpg/1280px-TurboGrafx16-Console-Set.jpg",
                            Marca = "NEC",
                            Nome = "PC Engine",
                            Regiao = "PAL",
                            Status = "ativo",
                            Valor = "20000"
                        },
                        new
                        {
                            Id = 2,
                            Ano = 1990,
                            Categoria = "Video game",
                            Compatibilidade = "Super Nintendo",
                            Condicao = "Bom",
                            Descricao = "Lançado pela Nintendo em 1990, o Super Nintendo Entertainment System (SNES) é um console que se destacou por seus jogos icônicos e gráficos avançados para a época.",
                            Fabricante = "Nintendo Co., Ltd.",
                            Foto = "https://upload.wikimedia.org/wikipedia/commons/7/77/Super_Nintendo_Entertainment_System_%28SNES%29_console_%28model_no._SNS-001%29.jpg",
                            Marca = "Nintendo",
                            Nome = "Super Nintendo Entertainment System",
                            Regiao = "PAL",
                            Status = "ativo",
                            Valor = "30000"
                        },
                        new
                        {
                            Id = 3,
                            Ano = 1989,
                            Categoria = "Video game",
                            Compatibilidade = "Mega Drive",
                            Condicao = "Muito Bom",
                            Descricao = "Conhecido como Mega Drive fora da América do Norte, o Sega Genesis foi um dos consoles de maior sucesso da Sega e competiu diretamente com o SNES.",
                            Fabricante = "Sega Enterprises, Ltd.",
                            Foto = "https://upload.wikimedia.org/wikipedia/commons/5/5f/Sega_Genesis_Console.jpg",
                            Marca = "Sega",
                            Nome = "Sega Genesis",
                            Regiao = "NTSC",
                            Status = "ativo",
                            Valor = "25000"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
