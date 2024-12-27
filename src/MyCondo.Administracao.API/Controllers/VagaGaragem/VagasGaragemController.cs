using MyCondo.Administracao.API.Controllers.Base;
using MyCondo.Administracao.Application.Services.Base;
using MyCondo.Administracao.Transfer.DataTransfer.VagaGaragem.Request;
using MyCondo.Administracao.Transfer.DataTransfer.VagaGaragem.Response;

namespace MyCondo.Administracao.API.Controllers.VagaGaragem;

public class VagasGaragemController : BaseController<VagasGaragemPesquisaRequest,
                                                     VagasGaragemInserirRequest,
                                                     VagasGaragemAtualizarRequest,
                                                     VagasGaragemExcluirRequest,
                                                     VagasGaragemResponse>
{
    public VagasGaragemController(IBaseService<VagasGaragemPesquisaRequest,
                                                     VagasGaragemInserirRequest,
                                                     VagasGaragemAtualizarRequest,
                                                     VagasGaragemExcluirRequest,
                                                     VagasGaragemResponse> service,
                                  ILogger<BaseController<VagasGaragemPesquisaRequest,
                                                     VagasGaragemInserirRequest,
                                                     VagasGaragemAtualizarRequest,
                                                     VagasGaragemExcluirRequest,
                                                     VagasGaragemResponse>> logger) : base(service, logger)
    {

    }
}