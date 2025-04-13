using System.Net;
using MediatR;
using RH.Domain.Entities;
using RH.Domain.Shareds.Notifications;
using RH.Domain.ViewModel;

namespace RH.Domain.Commands;

public record class IncluirCargoCommand(Cargo Cargo) : IRequest<Response<CargoViewModel>>;
