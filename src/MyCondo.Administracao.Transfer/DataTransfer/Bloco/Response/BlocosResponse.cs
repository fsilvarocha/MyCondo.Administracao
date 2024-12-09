using MyCondo.Administracao.Transfer.DataTransfer.Base;

namespace MyCondo.Administracao.Transfer.DataTransfer.Bloco.Response;

public class BlocosResponse : BaseResponse
{
    public string Nome { get; set; }
    public int QuantidadeAndar { get; set; }
   // public ICollection<ApartamentosResponse> Apartamentos { get; set; }
}
