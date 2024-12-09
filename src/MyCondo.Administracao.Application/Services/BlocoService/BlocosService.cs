using AutoMapper;
using MyCondo.Administracao.Application.Services.Base;
using MyCondo.Administracao.Application.Services.BlocoService.Interface;
using MyCondo.Administracao.Domain.Entities.Bloco;
using MyCondo.Administracao.Domain.Interface.Bloco;
using MyCondo.Administracao.Transfer.DataTransfer.Bloco.Request;
using MyCondo.Administracao.Transfer.DataTransfer.Bloco.Response;

namespace MyCondo.Administracao.Application.Services.BlocoService;

public class BlocosService : BaseService<Blocos,
                                         BlocosPesquisaRequest,
                                         BlocosInserirRequest,
                                         BlocosAtualizarRequest,
                                         BlocosExcluirRequest,
                                         BlocosResponse>, IBlocosService
{
    private readonly IBlocosRepository _blocosRepository;
    private readonly IMapper _mapper;

    public BlocosService(IBlocosRepository blocosRepository, IMapper mapper) : base(mapper, blocosRepository)
    {
        _blocosRepository = blocosRepository;
        _mapper = mapper;
    }
}