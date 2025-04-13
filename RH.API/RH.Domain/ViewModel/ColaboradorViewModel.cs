using RH.Domain.Entities;

namespace RH.Domain.ViewModel;

public class ColaboradorViewModel
{
    public Colaborador colaborador { get; set; }

    public ColaboradorViewModel(Colaborador colaborador)
    {
        this.colaborador = colaborador;
    }
}
