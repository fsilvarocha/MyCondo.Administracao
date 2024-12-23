using AutoMapper;
using MyCondo.Administracao.Application.Services.AreaComunService.Interface;
using MyCondo.Administracao.Application.Services.Base;
using MyCondo.Administracao.Domain.Entities.AreaComun;
using MyCondo.Administracao.Domain.Interface.AreaComun;
using MyCondo.Administracao.Transfer.DataTransfer.AreaComun.Request;
using MyCondo.Administracao.Transfer.DataTransfer.AreaComun.Response;

namespace MyCondo.Administracao.Application.Services.AreaComunService;

public class AreaComunsService : BaseService<AreaComuns,
                                             AreaComunsPesquisaRequest,
                                             AreaComunsInserirRequest,
                                             AreaComunsAtualizarRequest,
                                             AreaComunsExcluirRequest,
                                             AreaComunsResponse>, IAreaComunsService
{
    private readonly IAreaComunsRepository _areaComunsRepository;
    private readonly IMapper _mapper;

    public AreaComunsService(IAreaComunsRepository areaComunsRepository, IMapper mapper) : base(mapper, areaComunsRepository)
    {
        _areaComunsRepository = areaComunsRepository;
        _mapper = mapper;
    }
}