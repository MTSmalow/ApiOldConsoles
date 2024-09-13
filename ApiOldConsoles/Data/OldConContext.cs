using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiOldConsoles.Models;

namespace ApiOldConsoles.Data
{
    public class OldConContext : DbContext
    {
        public OldConContext (DbContextOptions<OldConContext> options)
            : base(options)
        {
        }

        public DbSet<ApiOldConsoles.Models.OldConsole> OldConsole { get; set; } = default!;

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OldConsole>().HasData(
                new OldConsole { Id = 1, Nome = "PC Engine",Descricao = "TurboGrafx-16, conhecido no Japão como PC Engine, é um console de videogame lançado em 1987 pela NEC e Hudson Soft. Após seu lançamento no Japão e sua aceitação nesse país, foi lançado em 1989 nos Estados Unidos batizado de Turbo Grafx-16", Marca = "NEC" , Fabricante="NEC Corporation",Categoria="Video game",Valor="20000",Ano=1989,Foto= "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d0/TurboGrafx16-Console-Set.jpg/1280px-TurboGrafx16-Console-Set.jpg",Status="ativo",Condicao="Semi-Novo",Regiao="PAL",Compatibilidade="PC Engine" },
                new OldConsole
                {
                    Id = 2,
                    Nome = "Super Nintendo Entertainment System",
                    Descricao = "Lançado pela Nintendo em 1990, o Super Nintendo Entertainment System (SNES) é um console que se destacou por seus jogos icônicos e gráficos avançados para a época.",
                    Marca = "Nintendo",
                    Fabricante = "Nintendo Co., Ltd.",
                    Categoria = "Video game",
                    Valor = "30000",
                    Ano = 1990,
                    Foto = "https://upload.wikimedia.org/wikipedia/commons/7/77/Super_Nintendo_Entertainment_System_%28SNES%29_console_%28model_no._SNS-001%29.jpg",
                    Status = "ativo",
                    Condicao = "Bom",
                    Regiao = "PAL",
                    Compatibilidade = "Super Nintendo"
                },
            new OldConsole
            {
                Id = 3,
                Nome = "Sega Genesis",
                Descricao = "Conhecido como Mega Drive fora da América do Norte, o Sega Genesis foi um dos consoles de maior sucesso da Sega e competiu diretamente com o SNES.",
                Marca = "Sega",
                Fabricante = "Sega Enterprises, Ltd.",
                Categoria = "Video game",
                Valor = "25000",
                Ano = 1989,
                Foto = "https://upload.wikimedia.org/wikipedia/commons/5/5f/Sega_Genesis_Console.jpg",
                Status = "ativo",
                Condicao = "Muito Bom",
                Regiao = "NTSC",
                Compatibilidade = "Mega Drive"
            },
            new OldConsole
            {
                Id = 4,
                Nome = "Sony PlayStation",
                Descricao = "Lançado em 1994, o Sony PlayStation foi um dos primeiros consoles de 32 bits e trouxe uma nova era de gráficos e jogos em 3D para o mercado.",
                Marca = "Sony",
                Fabricante = "Sony Computer Entertainment",
                Categoria = "Video game",
                Valor = "35000",
                Ano = 1994,
                Foto = "https://upload.wikimedia.org/wikipedia/commons/4/47/PlayStation-Console-wController.jpg",
                Status = "ativo",
                Condicao = "Excelente",
                Regiao = "NTSC",
                Compatibilidade = "PlayStation"
            },
            new OldConsole
            {
                Id = 5,
                Nome = "Nintendo 64",
                Descricao = "Lançado em 1996, o Nintendo 64 foi um dos primeiros consoles a oferecer gráficos 3D totalmente renderizados e é conhecido por seus jogos inovadores.",
                Marca = "Nintendo",
                Fabricante = "Nintendo Co., Ltd.",
                Categoria = "Video game",
                Valor = "40000",
                Ano = 1996,
                Foto = "https://upload.wikimedia.org/wikipedia/commons/7/7a/Nintendo_64_Console.jpg",
                Status = "ativo",
                Condicao = "Bom",
                Regiao = "NTSC",
                Compatibilidade = "Nintendo 64"
            },
            new OldConsole
            {
                Id = 6,
                Nome = "Atari Jaguar",
                Descricao = "Lançado em 1993, o Atari Jaguar é conhecido por ser o último console da Atari e por sua tentativa de entrar no mercado de consoles 64-bit.",
                Marca = "Atari",
                Fabricante = "Atari Corporation",
                Categoria = "Video game",
                Valor = "18000",
                Ano = 1993,
                Foto = "https://upload.wikimedia.org/wikipedia/commons/4/40/Atari_Jaguar_Console.jpg",
                Status = "ativo",
                Condicao = "Usado",
                Regiao = "NTSC",
                Compatibilidade = "Atari Jaguar"
            }
                );
        }
    }
}
