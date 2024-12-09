using MyCondo.Administracao.Application.Services.Base;
using MyCondo.Administracao.Transfer.DataTransfer.Bloco.Request;
using MyCondo.Administracao.Transfer.DataTransfer.Bloco.Response;

namespace MyCondo.Administracao.Application.Services.BlocoService.Interface;

public interface IBlocosService : IBaseService<BlocosPesquisaRequest,
                                               BlocosInserirRequest,
                                               BlocosAtualizarRequest,
                                               BlocosExcluirRequest,
                                               BlocosResponse>
{
}
