using Microsoft.EntityFrameworkCore;

namespace BibliotecaMVC.Models
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options)
            : base(options)
        {
        }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Admin> Admins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Admin padrão
            modelBuilder.Entity<Admin>().HasData(
                new Admin
                {
                    Id = 1,
                    Usuario = "admin",
                    Senha = "admin123"
                }
            );

            // Dados iniciais de livros
            modelBuilder.Entity<Livro>().HasData(
                new Livro
                {
                    Id = 1,
                    Titulo = "Dom Casmurro",
                    Autor = "Machado de Assis",
                    Categoria = "Literatura",
                    AnoPublicacao = 1899,
                    Descricao = "Um dos maiores clássicos da literatura brasileira, narrado pelo enigmático Bentinho.",
                    Disponivel = true,
                    ISBN = "978-85-0000-001-1"
                },
                new Livro
                {
                    Id = 2,
                    Titulo = "Uma Breve História do Tempo",
                    Autor = "Stephen Hawking",
                    Categoria = "Ciências",
                    AnoPublicacao = 1988,
                    Descricao = "Uma jornada pelo universo explicada de forma acessível pelo gênio Stephen Hawking.",
                    Disponivel = true,
                    ISBN = "978-85-0000-002-2"
                },
                new Livro
                {
                    Id = 3,
                    Titulo = "O Pequeno Príncipe",
                    Autor = "Antoine de Saint-Exupéry",
                    Categoria = "Infantil",
                    AnoPublicacao = 1943,
                    Descricao = "Um conto poético e filosófico sobre amizade, amor e os mistérios da vida.",
                    Disponivel = false,
                    ISBN = "978-85-0000-003-3"
                },
                new Livro
                {
                    Id = 4,
                    Titulo = "Sapiens",
                    Autor = "Yuval Noah Harari",
                    Categoria = "História",
                    AnoPublicacao = 2011,
                    Descricao = "Uma fascinante narrativa da história da humanidade desde a pré-história até os dias atuais.",
                    Disponivel = true,
                    ISBN = "978-85-0000-004-4"
                },
                new Livro
                {
                    Id = 5,
                    Titulo = "Código Limpo",
                    Autor = "Robert C. Martin",
                    Categoria = "Tecnologia",
                    AnoPublicacao = 2008,
                    Descricao = "Guia essencial para desenvolvedores que desejam escrever código legível e sustentável.",
                    Disponivel = true,
                    ISBN = "978-85-0000-005-5"
                },
                new Livro
                {
                    Id = 6,
                    Titulo = "A República",
                    Autor = "Platão",
                    Categoria = "Filosofia",
                    AnoPublicacao = -380,
                    Descricao = "Obra fundamental da filosofia ocidental que discute justiça, política e a natureza da alma.",
                    Disponivel = false,
                    ISBN = "978-85-0000-006-6"
                }
            );
        }
    }
}