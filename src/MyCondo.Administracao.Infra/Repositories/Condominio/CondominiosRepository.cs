using MyCondo.Administracao.Domain.Entities.Condominio;
using MyCondo.Administracao.Domain.Interface.Condominio;
using MyCondo.Administracao.Infra.Data;
using MyCondo.Administracao.Infra.Repositories.Base;

namespace MyCondo.Administracao.Infra.Repositories.Condominio;

public class CondominiosRepository(MyCondoContext context) : BaseRepository<Condominios>(context), ICondominiosRepository
{
    private readonly MyCondoContext _context = context;
}
