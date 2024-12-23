using MyCondo.Administracao.Application.Services.Base;
using MyCondo.Administracao.Transfer.DataTransfer.AreaComun.Request;
using MyCondo.Administracao.Transfer.DataTransfer.AreaComun.Response;

namespace MyCondo.Administracao.Application.Services.AreaComunService.Interface;

public interface IAreaComunsService : IBaseService<AreaComunsPesquisaRequest,
                                                   AreaComunsInserirRequest,
                                                   AreaComunsAtualizarRequest,
                                                   AreaComunsExcluirRequest,
                                                   AreaComunsResponse>
{
}