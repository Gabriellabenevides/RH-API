using RH.Domain.Entities;

namespace RH.Domain.ViewModel
{
    public class CargoViewModel
    {
        public Cargo Cargo { get; set; }

        public CargoViewModel(Cargo cargo)
        {
            this.Cargo = cargo;
        }
    }
}
