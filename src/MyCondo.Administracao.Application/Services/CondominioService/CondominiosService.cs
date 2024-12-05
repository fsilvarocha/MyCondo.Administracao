using AutoMapper;
using MyCondo.Administracao.Application.Services.Base;
using MyCondo.Administracao.Application.Services.CondominioService.Interface;
using MyCondo.Administracao.Domain.Entities.Condominio;
using MyCondo.Administracao.Domain.Interface.Condominio;
using MyCondo.Administracao.Transfer.DataTransfer.Condominio.Request;
using MyCondo.Administracao.Transfer.DataTransfer.Condominio.Response;

namespace MyCondo.Administracao.Application.Services.CondominioService;

public class CondominiosService : BaseService<Condominios,
                                             CondominiosPesquisaRequest,
                                             CondominiosInserirRequest,
                                             CondominiosAtualizarRequest,
                                             CondominiosExcluirRequest,
                                             CondominiosResponse>, ICondominiosService
{
    private readonly ICondominiosRepository _condominiosRepository;
    private readonly IMapper _mapper;

    public CondominiosService(ICondominiosRepository condominiosRepository, IMapper mapper) : base(mapper, condominiosRepository)
    {
        _condominiosRepository = condominiosRepository;
        _mapper = mapper;
    }
}
