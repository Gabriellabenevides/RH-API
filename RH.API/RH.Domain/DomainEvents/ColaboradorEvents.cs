using MediatR;

namespace RH.Domain.DomainEvents;

public class ColaboradorEvents : INotification
{
    public long IdColaborador { get; set; }
    public string Nome { get; set; }
    public string Cargo { get; set; }

    public ColaboradorEvents(long idColaborador, string nome, string cargo)
    {
        IdColaborador = idColaborador;
        Nome = nome;
        Cargo = cargo;
    }
}
