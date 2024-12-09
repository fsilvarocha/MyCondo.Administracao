using MyCondo.Administracao.Domain.Entities.Bloco;
using MyCondo.Administracao.Domain.Interface.Bloco;
using MyCondo.Administracao.Infra.Data;
using MyCondo.Administracao.Infra.Repositories.Base;

namespace MyCondo.Administracao.Infra.Repositories.Bloco;

public class BlocoRepository(MyCondoContext context) : BaseRepository<Blocos>(context), IBlocosRepository
{
    private readonly MyCondoContext _context1 = context;
}
