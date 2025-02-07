using BackEnd.DTO.Input;

namespace BackEnd.Services.Interfaces
{
    public interface ILivroService
    {

        public Task<List<Livro>> GetAllLivros();

        public Task<Livro> GetLivroById(int id);

        public Task AddLivroAsync(Livro livro);

        public Task UpdateLivroAsync(Livro livro);

        public Task DeleteLivroAsync(int id);
    }
}
