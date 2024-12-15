using System.Text.Json.Serialization;

namespace StructureWebAPI.Models
{
    public class AutorModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        [JsonIgnore] //Para ignorar na hora da criação
        public ICollection<LivroModel> Livros { get; set; }
    }
}
