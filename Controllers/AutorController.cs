using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StructureWebAPI.Dto.Autor;
using StructureWebAPI.Models;
using StructureWebAPI.Services.Autor;

namespace StructureWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly IAutorInterface _autor_interface;
        public AutorController(IAutorInterface autor_interface) 
        {
            _autor_interface = autor_interface;
        }

        [HttpGet("ListarAutores")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> ListarAutores()
        {
            var autores = await _autor_interface.listarAutores();
            return Ok(autores);
        }
        [HttpPost("CriarAutor")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> criarAutor(AutorCriacaoDto autor_criacao_dto)
        {
            var autores = await _autor_interface.criarAutor(autor_criacao_dto);
            return Ok(autores);
        }
        [HttpPut("EditarAutor")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> editarAutor(AutorEdicaoDto autor_edicao_dto)
        {
            var autores = await _autor_interface.editarAutor(autor_edicao_dto);
            return Ok(autores);
        }
        [HttpDelete("DeletarAutor/{id_autor}")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> removerAutor(int id_autor)
        {
            var autores = await _autor_interface.removerAutor(id_autor);
            return Ok(autores);
        }
    }
}
