using MyCondo.Administracao.Transfer.DataTransfer.Base;

namespace MyCondo.Administracao.Transfer.DataTransfer.Bloco.Request;

public class BlocosInserirRequest : BaseInserirRequest
{
    public string Nome { get; set; }
    public int QuantidadeAndar { get; set; }
    public int CondominiosId { get; set; }
}