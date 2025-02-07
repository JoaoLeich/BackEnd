using BackEnd.DTO.Input;
using BackEnd.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Services.Classes
{
    public class LivroService : ILivroService
    {

        private readonly LivroDbContext dbContext;

        public LivroService(LivroDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddLivroAsync(Livro livro)
        {

            if (livro.dataPublicacao > DateTime.UtcNow)
            {
                throw new InvalidDataException("Data Informada Do Livro Não Pode Ser Maior Que A Atual");
            }

            if (String.IsNullOrEmpty(livro.nome) || String.IsNullOrEmpty(livro.categoria))
            {
                throw new ArgumentException("O Campo Nome e Categoria Devem Estar Preenchidos");
            }

            await this.dbContext.AddAsync<Livro>(livro);

            await this.dbContext.SaveChangesAsync();
        }

        public async Task DeleteLivroAsync(int id)
        {
            var livro = this.dbContext.Livros.FindAsync(id).Result;

            this.dbContext.Remove<Livro>(livro);

            await this.dbContext.SaveChangesAsync();

        }

        public async Task<List<Livro>> GetAllLivros()
        {
            return await this.dbContext.Livros.ToListAsync();
        }

        public async Task<Livro> GetLivroById(int id)
        {
            return await this.dbContext.Livros.FindAsync(id);
        }

        public async Task UpdateLivroAsync(Livro livro)
        {

            if (livro.dataPublicacao > DateTime.UtcNow)
            {
                throw new InvalidDataException("Data Informada Do Livro Não Pode Ser Maior Que A Atual");
            }

            if (String.IsNullOrEmpty(livro.nome) || String.IsNullOrEmpty(livro.categoria))
            {
                throw new ArgumentException("O Campo Nome e Categoria Devem Estar Preenchidos");
            }

            this.dbContext.Entry(livro).State = EntityState.Modified;

            await this.dbContext.SaveChangesAsync();
        }
    }
}
