using AutoMapper;
using MyCondo.Administracao.Application.Services.ApartamentoService.Interface;
using MyCondo.Administracao.Application.Services.Base;
using MyCondo.Administracao.Domain.Entities.Apartamento;
using MyCondo.Administracao.Domain.Interface.Apartamento;
using MyCondo.Administracao.Transfer.DataTransfer.Apartamento.Request;
using MyCondo.Administracao.Transfer.DataTransfer.Apartamento.Response;

namespace MyCondo.Administracao.Application.Services.ApartamentoService;

public class ApartamentosService : BaseService<Apartamentos,
                                               ApartamentosPesquisaRequest,
                                               ApartamentosInserirRequest,
                                               ApartamentosAtualizarRequest,
                                               ApartamentosExcluirRequest,
                                               ApartamentosResponse>, IApartamentosService
{
    private readonly IApartamentosRepository _apartamentoRepository;
    private readonly IMapper _mapper;

    public ApartamentosService(IApartamentosRepository repository, IMapper mapper) : base(mapper, repository)
    {
        _apartamentoRepository = repository;
        _mapper = mapper;
    }
}
