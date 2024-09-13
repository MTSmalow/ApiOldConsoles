using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiOldConsoles.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "OldConsoles",
                columns: new[] { "Id", "Ano", "Categoria", "Compatibilidade", "Condicao", "Descricao", "Fabricante", "Foto", "Marca", "Nome", "Regiao", "Status", "Valor" },
                values: new object[] { 1, 1989, "Video game", "PC Engine", "Semi-Novo", "TurboGrafx-16, conhecido no Japão como PC Engine, é um console de videogame lançado em 1987 pela NEC e Hudson Soft. Após seu lançamento no Japão e sua aceitação nesse país, foi lançado em 1989 nos Estados Unidos batizado de Turbo Grafx-16", "NEC Corporation", "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d0/TurboGrafx16-Console-Set.jpg/1280px-TurboGrafx16-Console-Set.jpg", "NEC", "PC Engine", "PAL", "ativo", "20000" });

            migrationBuilder.InsertData(
                table: "OldConsoles",
                columns: new[] { "Id", "Ano", "Categoria", "Compatibilidade", "Condicao", "Descricao", "Fabricante", "Foto", "Marca", "Nome", "Regiao", "Status", "Valor" },
                values: new object[] { 2, 1990, "Video game", "Super Nintendo", "Bom", "Lançado pela Nintendo em 1990, o Super Nintendo Entertainment System (SNES) é um console que se destacou por seus jogos icônicos e gráficos avançados para a época.", "Nintendo Co., Ltd.", "https://upload.wikimedia.org/wikipedia/commons/7/77/Super_Nintendo_Entertainment_System_%28SNES%29_console_%28model_no._SNS-001%29.jpg", "Nintendo", "Super Nintendo Entertainment System", "PAL", "ativo", "30000" });

            migrationBuilder.InsertData(
                table: "OldConsoles",
                columns: new[] { "Id", "Ano", "Categoria", "Compatibilidade", "Condicao", "Descricao", "Fabricante", "Foto", "Marca", "Nome", "Regiao", "Status", "Valor" },
                values: new object[] { 3, 1989, "Video game", "Mega Drive", "Muito Bom", "Conhecido como Mega Drive fora da América do Norte, o Sega Genesis foi um dos consoles de maior sucesso da Sega e competiu diretamente com o SNES.", "Sega Enterprises, Ltd.", "https://upload.wikimedia.org/wikipedia/commons/5/5f/Sega_Genesis_Console.jpg", "Sega", "Sega Genesis", "NTSC", "ativo", "25000" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OldConsoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OldConsoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OldConsoles",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
