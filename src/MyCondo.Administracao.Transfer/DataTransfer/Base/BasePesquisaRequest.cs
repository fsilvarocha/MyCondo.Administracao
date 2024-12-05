using MyCondo.Administracao.Transfer.DataTransfer.Base.Interface;

namespace MyCondo.Administracao.Transfer.DataTransfer.Base;

public class BasePesquisaRequest : IPesquisaBase
{
    public int Id { get; set; }
    public Guid Tenante { get; set; }
}
