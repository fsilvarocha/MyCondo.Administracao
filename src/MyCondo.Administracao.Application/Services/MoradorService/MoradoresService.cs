using AutoMapper;
using MyCondo.Administracao.Application.Services.Base;
using MyCondo.Administracao.Application.Services.MoradorService.Interface;
using MyCondo.Administracao.Domain.Entities.Morador;
using MyCondo.Administracao.Domain.Interface.Morador;
using MyCondo.Administracao.Transfer.DataTransfer.Morador.Request;
using MyCondo.Administracao.Transfer.DataTransfer.Morador.Response;

namespace MyCondo.Administracao.Application.Services.MoradorService;

public class MoradoresService : BaseService<Moradores, MoradoresPesquisaRequest,
                                                       MoradoresInserirRequest,
                                                       MoradoresAtualizarRequest,
                                                       MoradoresExcluirRequest,
                                                       MoradoresResponse>, IMoradoresService
{
    private readonly IMoradoresRepository _moradorRepository;
    private readonly IMapper _mapper;

    public MoradoresService(IMoradoresRepository moradorRepository, IMapper mapper) : base(mapper, moradorRepository)
    {
        _moradorRepository = moradorRepository;
        _mapper = mapper;
    }
}
