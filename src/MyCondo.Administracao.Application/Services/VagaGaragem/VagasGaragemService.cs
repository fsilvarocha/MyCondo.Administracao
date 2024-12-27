using AutoMapper;
using MyCondo.Administracao.Application.Services.Base;
using MyCondo.Administracao.Application.Services.VagaGaragem.Interface;
using MyCondo.Administracao.Domain.Entities.VagaGaragem;
using MyCondo.Administracao.Domain.Interface.VagaGaragem;
using MyCondo.Administracao.Transfer.DataTransfer.VagaGaragem.Request;
using MyCondo.Administracao.Transfer.DataTransfer.VagaGaragem.Response;

namespace MyCondo.Administracao.Application.Services.VagaGaragem;

public class VagasGaragemService : BaseService<VagasGaragem, VagasGaragemPesquisaRequest,
                                                          VagasGaragemInserirRequest,
                                                          VagasGaragemAtualizarRequest,
                                                          VagasGaragemExcluirRequest,
                                                          VagasGaragemResponse>, IVagasGaragemService
{
    private readonly IVagasGaragemRepository _vagasGaragemRepository;
    private readonly IMapper _mapper;

    public VagasGaragemService(IVagasGaragemRepository vagasGaragemRepository, IMapper mapper) : base(mapper, vagasGaragemRepository)
    {
        _vagasGaragemRepository = vagasGaragemRepository;
        _mapper = mapper;
    }
}

