using System.Text.Json.Serialization;

namespace RH.Domain.Entities
{
    public class Colaborador
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateOnly DataAdmissao { get; set; }
        public DateOnly? DataDemissao { get; set; }
        public string Status { get; set; } // Ativo ou Inativo
        public int CargoId { get; set; } // FK para Cargo

        [JsonIgnore]
        public virtual Cargo Cargo { get; set; }

        // Construtor padrão necessário para o Entity Framework
        public Colaborador() { }

        // Construtor com parâmetros
        public Colaborador(string nome, DateOnly dataAdmissao, DateOnly? dataDemissao, string status, int cargoId)
        {
            Nome = nome;
            DataAdmissao = dataAdmissao;
            DataDemissao = dataDemissao;
            Status = status;
            CargoId = cargoId;
        }
    }
}
