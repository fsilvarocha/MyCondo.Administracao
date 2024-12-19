using MyCondo.Administracao.Domain.Entities.Apartamento;
using MyCondo.Administracao.Domain.Interface.Apartamento;
using MyCondo.Administracao.Infra.Data;
using MyCondo.Administracao.Infra.Repositories.Base;

namespace MyCondo.Administracao.Infra.Repositories.Apartamento;

public class ApartamentosRepository(MyCondoContext context) : BaseRepository<Apartamentos>(context), IApartamentosRepository
{
    private readonly MyCondoContext _context = context;
}
