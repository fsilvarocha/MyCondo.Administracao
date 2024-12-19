using MyCondo.Administracao.API.Controllers.Base;
using MyCondo.Administracao.Application.Services.Base;
using MyCondo.Administracao.Transfer.DataTransfer.Apartamento.Request;
using MyCondo.Administracao.Transfer.DataTransfer.Apartamento.Response;

namespace MyCondo.Administracao.API.Controllers.Apartamento;

public class ApartamentosController : BaseController<ApartamentosPesquisaRequest,
                                                     ApartamentosInserirRequest,
                                                     ApartamentosAtualizarRequest,
                                                     ApartamentosExcluirRequest,
                                                     ApartamentosResponse>
{
    public ApartamentosController(IBaseService<ApartamentosPesquisaRequest,
                                                     ApartamentosInserirRequest,
                                                     ApartamentosAtualizarRequest,
                                                     ApartamentosExcluirRequest,
                                                     ApartamentosResponse> service,
                                  ILogger<BaseController<ApartamentosPesquisaRequest,
                                                     ApartamentosInserirRequest,
                                                     ApartamentosAtualizarRequest,
                                                     ApartamentosExcluirRequest,
                                                     ApartamentosResponse>> logger) : base(service, logger)
    {

    }
}
