using MediatR;
using RH.Domain.Entities;
using RH.Domain.Shareds.Notifications;
using RH.Domain.ViewModel;

namespace RH.Domain.Commands;

public record class IncluirColaboradorCommand(string Nome, DateOnly DataAdmissao, DateOnly? DataDemissao,string Status,int CargoId) : IRequest<Response<ColaboradorViewModel>>;

