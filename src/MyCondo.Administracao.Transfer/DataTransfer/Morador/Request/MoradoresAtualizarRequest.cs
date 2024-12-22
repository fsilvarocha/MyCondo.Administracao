using MyCondo.Administracao.Domain.Utils.Enumeradores;

namespace MyCondo.Administracao.Transfer.DataTransfer.Morador.Request;

public class MoradoresAtualizarRequest
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public ETipoMorador TipoMorador { get; set; }
}
