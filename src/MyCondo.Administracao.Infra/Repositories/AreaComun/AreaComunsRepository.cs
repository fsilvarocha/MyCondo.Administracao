using MyCondo.Administracao.Domain.Entities.AreaComun;
using MyCondo.Administracao.Domain.Interface.AreaComun;
using MyCondo.Administracao.Infra.Data;
using MyCondo.Administracao.Infra.Repositories.Base;

namespace MyCondo.Administracao.Infra.Repositories.AreaComun;

public class AreaComunsRepository(MyCondoContext context) : BaseRepository<AreaComuns>(context), IAreaComunsRepository
{
    private readonly MyCondoContext _context = context;
}
