using StructureWebAPI.Data;
using StructureWebAPI.Models;

namespace StructureWebAPI.Services.Autor
{
    public class AutorService : IAutorInterface
    {
        private readonly AppDbContext _context;
        public AutorService(AppDbContext context) 
        {
            _context = context;
        }
        public Task<ResponseModel<AutorModel>> buscarAutorId(int id_autor)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<AutorModel>> buscarAutorIdLivro(int id_livro)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<AutorModel>>> listarAutores()
        {
            throw new NotImplementedException();
        }
    }
}
