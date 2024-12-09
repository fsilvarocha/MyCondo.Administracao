using MyCondo.Administracao.API.Controllers.Base;
using MyCondo.Administracao.Application.Services.Base;
using MyCondo.Administracao.Transfer.DataTransfer.Bloco.Request;
using MyCondo.Administracao.Transfer.DataTransfer.Bloco.Response;

namespace MyCondo.Administracao.API.Controllers.Bloco;

public class BlocosController : BaseController<BlocosPesquisaRequest,
                                               BlocosInserirRequest,
                                               BlocosAtualizarRequest,
                                               BlocosExcluirRequest,
                                               BlocosResponse>
{
    public BlocosController(IBaseService<BlocosPesquisaRequest,
                                               BlocosInserirRequest,
                                               BlocosAtualizarRequest,
                                               BlocosExcluirRequest,
                                               BlocosResponse> service,
                            ILogger<BaseController<BlocosPesquisaRequest,
                                               BlocosInserirRequest,
                                               BlocosAtualizarRequest,
                                               BlocosExcluirRequest,
                                               BlocosResponse>> logger) : base(service, logger)
    {
    }
}
