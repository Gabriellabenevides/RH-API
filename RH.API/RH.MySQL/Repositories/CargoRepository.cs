using RH.Domain.Entities;
using RH.Domain.Interface;
using RH.MySQL.MySQL;

namespace RH.MySQL.Repositories;

public class CargoRepository : Repository<Cargo>, ICargoRepository
{
    public CargoRepository(MySQLContext context) : base(context)
    {
    }
}
