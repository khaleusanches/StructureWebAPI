using Microsoft.EntityFrameworkCore;
using StructureWebAPI.Data;
using StructureWebAPI.Dto.Autor;
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

        public async Task<ResponseModel<List<AutorModel>>> criarAutor(AutorCriacaoDto autor_criacao_dto)
        {
            ResponseModel<List<AutorModel>> resposta = new ResponseModel<List<AutorModel>>();
            try
            {
                AutorModel autor = new AutorModel() 
                { 
                    Nome = autor_criacao_dto.Nome,
                    Sobrenome = autor_criacao_dto.Sobrenome
                };
                _context.Autores.Add(autor);
                await _context.SaveChangesAsync();
                resposta.Dados = await _context.Autores.ToListAsync();
                resposta.Message = "Sucesso";
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Status = false;
                resposta.Message = ex.Message;
                return resposta;
            }

        }

        public async Task<ResponseModel<List<AutorModel>>> editarAutor(AutorEdicaoDto autor_edicao_dto)
        {
            ResponseModel<List<AutorModel>> resposta = new ResponseModel<List<AutorModel>>();
            try
            {
                var autor = await _context.Autores.FirstOrDefaultAsync(predicate: autor_banco => autor_banco.Id == autor_edicao_dto.Id);
                if(autor == null)
                {
                    resposta.Message = "Autor não encontrado";
                    return resposta;
                }
                autor.Nome = autor_edicao_dto.Nome;
                autor.Sobrenome = autor_edicao_dto.Sobrenome;
                _context.Update(autor);
                await _context.SaveChangesAsync();
                resposta.Dados = await _context.Autores.ToListAsync();
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Status = false;
                resposta.Message = ex.Message;
                return resposta;
            }
        }

        public async Task<ResponseModel<List<AutorModel>>> listarAutores()
        {
            ResponseModel<List<AutorModel>> resposta = new ResponseModel<List<AutorModel>>();
            try
            {
                var autores = await _context.Autores.ToListAsync();
                resposta.Dados = autores;
                resposta.Message = "Sucesso";
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Message = ex.Message;
                resposta.Status = false;
                return resposta;
            }
        }

        public async Task<ResponseModel<List<AutorModel>>> removerAutor(int id_autor)
        {
            ResponseModel<List<AutorModel>> resposta = new ResponseModel<List<AutorModel>>();
            try
            {
                var autor = await _context.Autores.FindAsync(id_autor);
                if (autor == null)
                {
                    resposta.Message = "Autor não encontrado";
                }
                _context.Autores.Remove(autor);
                await _context.SaveChangesAsync();
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Status = false;
                resposta.Message = ex.Message;
                return resposta;
            }
        }
    }
}
