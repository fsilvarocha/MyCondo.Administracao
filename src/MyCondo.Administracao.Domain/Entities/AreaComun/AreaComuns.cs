using MyCondo.Administracao.Domain.Entities.Base;
using MyCondo.Administracao.Domain.Entities.Condominio;
using MyCondo.Administracao.Domain.Utils.Enumeradores;
using System.Text.Json.Serialization;

namespace MyCondo.Administracao.Domain.Entities.AreaComun;

public class AreaComuns : BaseEntity
{
    public string Nome { get; protected set; }
    public string Descricao { get; protected set; }
    public decimal ValorLocacao { get; protected set; } = 0;
    public bool ExcluirBoletoAoCancelar { get; protected set; } = true;
    public bool LiberarBoletoAtoReserva { get; protected set; } = true;
    public bool? PagarBoletoAposReserva { get; protected set; } = true;
    public int DiasAntecedenciaLocacao { get; protected set; } = 5;
    public TimeSpan? HoraMinima { get; protected set; } = TimeSpan.FromHours(1);
    public TimeSpan? HoraMaxima { get; protected set; } = TimeSpan.FromHours(2);
    public TimeSpan? HorarioInicial { get; protected set; } = TimeSpan.FromHours(0);
    public TimeSpan? HorarioMaxima { get; protected set; } = TimeSpan.FromHours(23) + TimeSpan.FromMinutes(59);
    public bool PermitirLocacaoInadimplentes { get; protected set; } = false;
    public int PrazoReserva { get; protected set; } = 60;
    public int PrazoCancelamento { get; protected set; } = 2;
    public int QuantidadeLocacaoTotal { get; protected set; } = 3;
    public DateTime? DataVencimentoBoleto { get; protected set; }
    public bool PermitirMaisDeUmaReservaDia { get; protected set; } = false;
    public bool ExibirReservaCancelada { get; protected set; } = false;
    public EStatus Status { get; protected set; } = EStatus.Ativo;
    public int CondominiosId { get; protected set; }
    [JsonIgnore]
    public Condominios Condominios { get; set; }

    public AreaComuns()
    {
        SetStatus(EStatus.Ativo);
    }

    public void SetNome(string nome) => Nome = nome;
    public void SetDescricao(string descricao) => Descricao = descricao;
    public void SetValorLocacao(decimal valorLocacao) => ValorLocacao = valorLocacao;
    public void SetExcluirBoletoAoCancelar(bool excluirBoleto) => ExcluirBoletoAoCancelar = excluirBoleto;
    public void SetLiberarBoletoAtoReserva(bool liberarBoleto) => LiberarBoletoAtoReserva = liberarBoleto;
    public void SetPagarBoletoAposReserva(bool? pagarBoleto) => PagarBoletoAposReserva = pagarBoleto;
    public void SetDiasAntecedenciaLocacao(int dias) => DiasAntecedenciaLocacao = dias;
    public void SetHoraMinima(TimeSpan? horaMinima) => HoraMinima = horaMinima;
    public void SetHoraMaxima(TimeSpan? horaMaxima) => HoraMaxima = horaMaxima;
    public void SetHorarioInicial(TimeSpan? horarioInicial) => HorarioInicial = horarioInicial;
    public void SetHorarioMaxima(TimeSpan? horarioMaxima) => HorarioMaxima = horarioMaxima;
    public void SetPermitirLocacaoInadimplentes(bool permitirLocacaoInadimplentes) => PermitirLocacaoInadimplentes = permitirLocacaoInadimplentes;
    public void SetPrazoReserva(int prazo) => PrazoReserva = prazo;
    public void SetPrazoCancelamento(int prazo) => PrazoCancelamento = prazo;
    public void SetQuantidadeLocacaoTotal(int quantidade) => QuantidadeLocacaoTotal = quantidade;
    public void SetDataVencimentoBoleto(DateTime data) => DataVencimentoBoleto = data;
    public void SetPermitirMaisDeUmaReservaDia(bool permitirMaisDeUmaReservaDia) => PermitirMaisDeUmaReservaDia = permitirMaisDeUmaReservaDia;
    public void SetExibirReservaCancelada(bool exibirReservaCancelada) => ExibirReservaCancelada = exibirReservaCancelada;
    public void SetStatus(EStatus status) => Status = status;
}
