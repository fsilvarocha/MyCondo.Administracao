using MyCondo.Administracao.Domain.Utils.Enumeradores;
using MyCondo.Administracao.Transfer.DataTransfer.Base;

namespace MyCondo.Administracao.Transfer.DataTransfer.Apartamento.Response;

public class ApartamentosResponse : BaseResponse
{
    public string Numero { get; set; }
    public int Andar { get; set; }
    public ETipoApartamento TipoApartamento { get; set; }
    public string TipoApartamentoDescricao { get; set; }

   // public ICollection<MoradoresResponse> Moradores { get; set; }
}
