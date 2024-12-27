using MyCondo.Administracao.Domain.Utils.Enumeradores;
using MyCondo.Administracao.Transfer.DataTransfer.Base;
using MyCondo.Administracao.Transfer.DataTransfer.Morador.Response;

namespace MyCondo.Administracao.Transfer.DataTransfer.Apartamento.Response;

public class ApartamentosResponse : BaseResponse
{
    public string Numero { get; set; }
    public int Andar { get; set; }
    public ETipoApartamento TipoApartamento { get; set; }
    public string TipoApartamentoDescricao { get; set; }
    public ESimNao PossuiVagasDemarcada { get; set; }
    public string PossuiVagasDemarcadaDescricao { get; set; }

    public ICollection<MoradoresResponse> Moradores { get; set; }
}
