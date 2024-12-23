using MyCondo.Administracao.API.Controllers.Base;
using MyCondo.Administracao.Application.Services.Base;
using MyCondo.Administracao.Transfer.DataTransfer.AreaComun.Request;
using MyCondo.Administracao.Transfer.DataTransfer.AreaComun.Response;

namespace MyCondo.Administracao.API.Controllers.AreaComun;

public class AreaComunsController : BaseController<AreaComunsPesquisaRequest,
                                               AreaComunsInserirRequest,
                                               AreaComunsAtualizarRequest,
                                               AreaComunsExcluirRequest,
                                               AreaComunsResponse>
{
    public AreaComunsController(IBaseService<AreaComunsPesquisaRequest,
                                               AreaComunsInserirRequest,
                                               AreaComunsAtualizarRequest,
                                               AreaComunsExcluirRequest,
                                               AreaComunsResponse> service,
                            ILogger<BaseController<AreaComunsPesquisaRequest,
                                               AreaComunsInserirRequest,
                                               AreaComunsAtualizarRequest,
                                               AreaComunsExcluirRequest,
                                               AreaComunsResponse>> logger) : base(service, logger)
    {
    }
}

