using StructureWebAPI.Dto.Autor;
using StructureWebAPI.Models;

namespace StructureWebAPI.Services.Autor
{
    public interface IAutorInterface
    {
        Task<ResponseModel<List<AutorModel>>> listarAutores();
        Task<ResponseModel<AutorModel>> buscarAutorId(int id_autor);
        Task<ResponseModel<AutorModel>> buscarAutorIdLivro(int id_livro);

        Task<ResponseModel<List<AutorModel>>> criarAutor(AutorCriacaoDto autor_criacao_dto);
        Task<ResponseModel<List<AutorModel>>> editarAutor(AutorEdicaoDto autor_edicao_dto);
        Task<ResponseModel<List<AutorModel>>> removerAutor(int id_autor);
    }
}
