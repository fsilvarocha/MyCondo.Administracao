using MyCondo.Administracao.Domain.Utils.Enumeradores;

namespace MyCondo.Administracao.Transfer.DataTransfer.Apartamento.Request;

public class ApartamentosAtualizarRequest
{
    public string Numero { get; set; }
    public int Andar { get; set; }
    public ETipoApartamento TipoApartamento { get; set; }
}
