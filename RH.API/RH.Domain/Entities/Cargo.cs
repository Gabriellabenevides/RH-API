using System.Text.Json.Serialization;

namespace RH.Domain.Entities
{
    public class Cargo
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public Cargo(string nome, string descricao)
        { 
            Nome = nome;
            Descricao = descricao;
        }
    }
}
