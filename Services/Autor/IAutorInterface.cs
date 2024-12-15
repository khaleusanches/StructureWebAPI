using StructureWebAPI.Models;

namespace StructureWebAPI.Services.Autor
{
    public interface IAutorInterface
    {
        Task<ResponseModel<List<AutorModel>>> listarAutores();
        Task<ResponseModel<AutorModel>> buscarAutorId(int id_autor);
        Task<ResponseModel<AutorModel>> buscarAutorIdLivro(int id_livro);
    }
}
