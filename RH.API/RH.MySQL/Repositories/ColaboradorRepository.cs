using RH.Domain.Entities;
using RH.Domain.Interface;
using RH.MySQL.MySQL;

namespace RH.MySQL.Repositories;

public class ColaboradorRepository : Repository<Colaborador>, IColaboradorRepository
{
    public ColaboradorRepository(MySQLContext context) : base(context)
    {
    }
}
