using MyCondo.Administracao.Domain.Entities.VagaGaragem;
using MyCondo.Administracao.Domain.Interface.VagaGaragem;
using MyCondo.Administracao.Infra.Data;
using MyCondo.Administracao.Infra.Repositories.Base;

namespace MyCondo.Administracao.Infra.Repositories.VagaGaragem;

public class VagasGaragemRepository(MyCondoContext context) : BaseRepository<VagasGaragem>(context), IVagasGaragemRepository
{
    private readonly MyCondoContext _context = context;
}
