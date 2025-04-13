namespace RH.Domain.Entities
{
    public class Colaborador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateOnly DataAdmissao { get; set; }
        public DateOnly DataDemissao { get; set; }
        public string Status { get; set; } // Ativo ou Inativo
        public Cargo Cargo { get; set; }
    }
}
