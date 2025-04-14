using MediatR;
using RH.Domain.Commands;
using RH.Domain.Entities;
using RH.Domain.Interface;
using RH.Domain.Shareds.Notifications;
using RH.Domain.ViewModel;

namespace RH.Application.Handlers.CargoHandlers;

public class IncluirCargoHandler : IRequestHandler<IncluirCargoCommand, Response<CargoViewModel>>
{
    private readonly ICargoRepository _cargoRepository;
    public IncluirCargoHandler(ICargoRepository cargoRepository)
    {
        _cargoRepository = cargoRepository;
    }
    public async Task<Response<CargoViewModel>> Handle(IncluirCargoCommand request, CancellationToken cancellationToken)
    {
        var cargo = new Cargo(request.Cargo.Nome, request.Cargo.Descricao);

        await _cargoRepository.AddAsync(cargo);

        var cargoViewModel = new CargoViewModel(cargo);

        return new(cargoViewModel);
    }
}
