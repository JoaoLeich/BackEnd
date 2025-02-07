
using Microsoft.EntityFrameworkCore;

public class LivroDbContext : DbContext
{

    public LivroDbContext(DbContextOptions<LivroDbContext> options) : base(options)
    {
    
    }

    public DbSet<Livro> Livros { get; set; }

}