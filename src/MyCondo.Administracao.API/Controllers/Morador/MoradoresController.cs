using MyCondo.Administracao.API.Controllers.Base;
using MyCondo.Administracao.Application.Services.Base;
using MyCondo.Administracao.Transfer.DataTransfer.Morador.Request;
using MyCondo.Administracao.Transfer.DataTransfer.Morador.Response;

namespace MyCondo.Administracao.API.Controllers.Morador;

public class MoradoresController : BaseController<MoradoresPesquisaRequest,
                                                  MoradoresInserirRequest,
                                                  MoradoresAtualizarRequest,
                                                  MoradoresExcluirRequest,
                                                  MoradoresResponse>
{
    public MoradoresController(
        IBaseService<MoradoresPesquisaRequest,
                     MoradoresInserirRequest,
                     MoradoresAtualizarRequest,
                     MoradoresExcluirRequest,
                     MoradoresResponse> service,
        ILogger<BaseController<MoradoresPesquisaRequest,
                               MoradoresInserirRequest,
                               MoradoresAtualizarRequest,
                               MoradoresExcluirRequest,
                               MoradoresResponse>> logger)
        : base(service, logger)
    {
    }
}
