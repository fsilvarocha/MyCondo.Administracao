using Microsoft.AspNetCore.Mvc;
using MyCondo.Administracao.API.Controllers.Base;
using MyCondo.Administracao.Application.Services.Base;
using MyCondo.Administracao.Transfer.DataTransfer.Condominio.Request;
using MyCondo.Administracao.Transfer.DataTransfer.Condominio.Response;

namespace MyCondo.Administracao.API.Controllers.Condominio;

public class CondominiosController : BaseController<CondominiosPesquisaRequest,
                                                      CondominiosInserirRequest,
                                                      CondominiosAtualizarRequest,
                                                      CondominiosExcluirRequest,
                                                      CondominiosResponse>
{
    public CondominiosController(IBaseService<CondominiosPesquisaRequest,
                                              CondominiosInserirRequest,
                                              CondominiosAtualizarRequest,
                                              CondominiosExcluirRequest,
                                              CondominiosResponse> service,
                                 ILogger<BaseController<CondominiosPesquisaRequest,
                                                        CondominiosInserirRequest,
                                                        CondominiosAtualizarRequest,
                                                        CondominiosExcluirRequest,
                                                        CondominiosResponse>> logger) : base(service, logger)
    {

    }
}
