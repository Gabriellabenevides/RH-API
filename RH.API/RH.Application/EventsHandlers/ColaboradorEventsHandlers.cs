using MediatR;
using RH.Domain.DomainEvents;
using RH.Application.Service;
using System.Text.Json;

namespace RH.Application.EventsHandlers;

public class ColaboradorEventsHandlers : INotificationHandler<ColaboradorEvents>
{
    private readonly RabbitMQService _rabbitMQService;

    public ColaboradorEventsHandlers(RabbitMQService rabbitMQService)
    {
        _rabbitMQService = rabbitMQService;
    }

    public async Task Handle(ColaboradorEvents notification, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Evento recebido: Colaborador {notification.Nome} com cargo {notification.Cargo} foi salvo.");

        // Serializa o evento para JSON
        var message = JsonSerializer.Serialize(notification);

        // Envia a mensagem para o RabbitMQ
        await _rabbitMQService.SendMessageAsync("ColaboradorQueue", message);
    }
}
