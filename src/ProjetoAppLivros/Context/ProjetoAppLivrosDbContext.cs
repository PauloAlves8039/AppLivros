using ProjetoAppLivros.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjetoAppLivros.Context
{
    /// <summary>
    /// Classe responsável por herda o contexto da classe DbContext para uso do Entity Framework no mapeamento do banco de dados.  
    /// </summary>
    public class ProjetoAppLivrosDbContext : DbContext
    {
        /// <value>Propriedade responsável por definir a tabela Livro.</value>
        public DbSet<Livro> Livros { get; set; }

        /// <summary>
        /// Construtor sobrescito para receber informações referentes ao uso de injeção de dependência.
        /// </summary>
        /// <param name="opts">Parâmetro responsável pelas configurações de funcionamento do DbContext.</param>
        /// <returns>Repassando as opções de inicialização do DbContex.</returns>
        public ProjetoAppLivrosDbContext(DbContextOptions<ProjetoAppLivrosDbContext> opts) : base (opts)
        {
            
        }

        /// <summary>
        /// Método sobrescrito para configuração do modelo da entidade Livro e seus campos no banco de dados.
        /// </summary>
        /// <param name="modelBuilder">Propriedade responsável pela criação de relação entre a entidade Livro e o banco de dados.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livro>((builder) => 
            {
                builder.ToTable("LIV_LIVRO");
                builder.Property(p => p.Id).HasColumnName("LIV_ID");
                builder.HasKey(p => p.Id);
                builder.Property(p => p.Titulo).HasColumnName("LIV_TITULO").HasMaxLength(50).IsRequired();
                builder.Property(p => p.Autor).HasColumnName("LIV_AUTOR").HasMaxLength(50).IsRequired();
                builder.Property(p => p.Genero).HasColumnName("LIV_GENERO").HasMaxLength(50).IsRequired();
                builder.Property(p => p.Lancamento).HasColumnName("LIV_LANCAMENTO").IsRequired();
                builder.Property(p => p.Editora).HasColumnName("LIV_EDITORA").HasMaxLength(30).IsRequired();
            });
        }
    }
}