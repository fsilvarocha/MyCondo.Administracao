using MyCondo.Administracao.Application.Services.Base;
using MyCondo.Administracao.Transfer.DataTransfer.Morador.Request;
using MyCondo.Administracao.Transfer.DataTransfer.Morador.Response;

namespace MyCondo.Administracao.Application.Services.MoradorService.Interface;

public interface IMoradoresService : IBaseService<MoradoresPesquisaRequest,
                                                  MoradoresInserirRequest,
                                                  MoradoresAtualizarRequest,
                                                  MoradoresExcluirRequest,
                                                  MoradoresResponse>
{
}
