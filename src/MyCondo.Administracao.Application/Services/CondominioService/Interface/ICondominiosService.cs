using MyCondo.Administracao.Application.Services.Base;
using MyCondo.Administracao.Transfer.DataTransfer.Condominio.Request;
using MyCondo.Administracao.Transfer.DataTransfer.Condominio.Response;

namespace MyCondo.Administracao.Application.Services.CondominioService.Interface;

public interface ICondominiosService : IBaseService<CondominiosPesquisaRequest,
                                                    CondominiosInserirRequest,
                                                    CondominiosAtualizarRequest,
                                                    CondominiosExcluirRequest,
                                                    CondominiosResponse>
{
}
