using MyCondo.Administracao.Domain.Utils.Enumeradores;
using MyCondo.Administracao.Transfer.DataTransfer.Base;

namespace MyCondo.Administracao.Transfer.DataTransfer.Morador.Response;

public class MoradoresResponse : BaseResponse
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Foto { get; set; }
    public ETipoMorador TipoMorador { get; set; }
    public string TipoMoradorDescricao { get; set; }
}
