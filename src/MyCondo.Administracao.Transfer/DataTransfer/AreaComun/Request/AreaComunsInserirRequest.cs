using MyCondo.Administracao.Domain.Utils.Enumeradores;
using MyCondo.Administracao.Transfer.DataTransfer.Base;

namespace MyCondo.Administracao.Transfer.DataTransfer.AreaComun.Request;

public class AreaComunsInserirRequest : BaseInserirRequest
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public decimal ValorLocacao { get; set; }
    public bool ExcluirBoletoAoCancelar { get; set; }
    public bool LiberarBoletoAtoReserva { get; set; }
    public bool? PagarBoletoAposReserva { get; set; }
    public int DiasAntecedenciaLocacao { get; set; }
    public TimeSpan? HoraMinima { get; set; }
    public TimeSpan? HoraMaxima { get; set; }
    public TimeSpan? HorarioInicial { get; set; }
    public TimeSpan? HorarioMaxima { get; set; }
    public bool PermitirLocacaoInadimplentes { get; set; }
    public int PrazoReserva { get; set; }
    public int PrazoCancelamento { get; set; }
    public int QuantidadeLocacaoTotal { get; set; }
    public DateTime? DataVencimentoBoleto { get; set; }
    public bool PermitirMaisDeUmaReservaDia { get; set; }
    public bool ExibirReservaCancelada { get; set; }
    public EStatus Status { get; set; }
    public int CondominiosId { get; set; }
}
