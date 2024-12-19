using MyCondo.Administracao.Application.Services.Base;
using MyCondo.Administracao.Transfer.DataTransfer.Apartamento.Request;
using MyCondo.Administracao.Transfer.DataTransfer.Apartamento.Response;

namespace MyCondo.Administracao.Application.Services.ApartamentoService.Interface;

public interface IApartamentosService : IBaseService<ApartamentosPesquisaRequest,
                                                 ApartamentosInserirRequest,
                                                 ApartamentosAtualizarRequest,
                                                 ApartamentosExcluirRequest,
                                                 ApartamentosResponse>
{

}

