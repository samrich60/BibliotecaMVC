using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BibliotecaMVC.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Livros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(type: "TEXT", nullable: false),
                    Autor = table.Column<string>(type: "TEXT", nullable: false),
                    Categoria = table.Column<string>(type: "TEXT", nullable: false),
                    AnoPublicacao = table.Column<int>(type: "INTEGER", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    Disponivel = table.Column<bool>(type: "INTEGER", nullable: false),
                    ISBN = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livros", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Livros",
                columns: new[] { "Id", "AnoPublicacao", "Autor", "Categoria", "Descricao", "Disponivel", "ISBN", "Titulo" },
                values: new object[,]
                {
                    { 1, 1899, "Machado de Assis", "Literatura", "Um dos maiores clássicos da literatura brasileira, narrado pelo enigmático Bentinho.", true, "978-85-0000-001-1", "Dom Casmurro" },
                    { 2, 1988, "Stephen Hawking", "Ciências", "Uma jornada pelo universo explicada de forma acessível pelo gênio Stephen Hawking.", true, "978-85-0000-002-2", "Uma Breve História do Tempo" },
                    { 3, 1943, "Antoine de Saint-Exupéry", "Infantil", "Um conto poético e filosófico sobre amizade, amor e os mistérios da vida.", false, "978-85-0000-003-3", "O Pequeno Príncipe" },
                    { 4, 2011, "Yuval Noah Harari", "História", "Uma fascinante narrativa da história da humanidade desde a pré-história até os dias atuais.", true, "978-85-0000-004-4", "Sapiens" },
                    { 5, 2008, "Robert C. Martin", "Tecnologia", "Guia essencial para desenvolvedores que desejam escrever código legível e sustentável.", true, "978-85-0000-005-5", "Código Limpo" },
                    { 6, -380, "Platão", "Filosofia", "Obra fundamental da filosofia ocidental que discute justiça, política e a natureza da alma.", false, "978-85-0000-006-6", "A República" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Livros");
        }
    }
}
