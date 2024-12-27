using MyCondo.Administracao.Application.Services.Base;
using MyCondo.Administracao.Transfer.DataTransfer.VagaGaragem.Request;
using MyCondo.Administracao.Transfer.DataTransfer.VagaGaragem.Response;

namespace MyCondo.Administracao.Application.Services.VagaGaragem.Interface;

public interface IVagasGaragemService : IBaseService<VagasGaragemPesquisaRequest,
                                                     VagasGaragemInserirRequest,
                                                     VagasGaragemAtualizarRequest,
                                                     VagasGaragemExcluirRequest,
                                                     VagasGaragemResponse>
{
}
