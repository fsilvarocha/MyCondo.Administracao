using MyCondo.Administracao.Domain.Entities.Morador;
using MyCondo.Administracao.Domain.Interface.Morador;
using MyCondo.Administracao.Infra.Data;
using MyCondo.Administracao.Infra.Repositories.Base;

namespace MyCondo.Administracao.Infra.Repositories.Morador;

public class MoradoresRepository(MyCondoContext context) : BaseRepository<Moradores>(context), IMoradoresRepository
{
    private readonly MyCondoContext _context = context;
}

