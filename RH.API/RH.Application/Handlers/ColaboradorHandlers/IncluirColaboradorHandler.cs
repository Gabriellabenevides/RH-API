﻿using MediatR;
using RH.Domain.Commands;
using RH.Domain.DomainEvents;
using RH.Domain.Entities;
using RH.Domain.Interface;
using RH.Domain.Shareds.Notifications;
using RH.Domain.ViewModel;

namespace RH.Application.Handlers.ColaboradorHandlers;

internal class IncluirColaboradorHandler : IRequestHandler<IncluirColaboradorCommand, Response<ColaboradorViewModel>>
{
    private readonly IColaboradorRepository _colaboradorRepository;
    private readonly ICargoRepository _cargoRepository;
    private readonly IMediator _mediator; 

    public IncluirColaboradorHandler(IColaboradorRepository colaboradorRepository, ICargoRepository cargoRepository, IMediator mediator) 
    {
        _colaboradorRepository = colaboradorRepository;
        _cargoRepository = cargoRepository;
        _mediator = mediator;
    }

    public async Task<Response<ColaboradorViewModel>> Handle(IncluirColaboradorCommand request, CancellationToken cancellationToken)
    {
        var cargo = await _cargoRepository.GetByIdAsync(request.CargoId);
        if (cargo == null)
        {
            return new Response<ColaboradorViewModel>(new List<Notification> { new Notification("Cargo não encontrado") });
        }

        var colaborador = new Colaborador(request.Nome, request.DataAdmissao, request.DataDemissao, request.Status, cargo.Id);
        await _colaboradorRepository.AddAsync(colaborador);

        // Publicar o evento
        var colaboradorEvent = new ColaboradorEvents(colaborador.Id, colaborador.Nome, cargo.Nome);
        await _mediator.Publish(colaboradorEvent, cancellationToken);

        var colaboradorViewModel = new ColaboradorViewModel(colaborador);
        return new(colaboradorViewModel);
    }
}
