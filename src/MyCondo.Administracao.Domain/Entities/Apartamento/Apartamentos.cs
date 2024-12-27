using MyCondo.Administracao.Domain.Entities.Base;
using MyCondo.Administracao.Domain.Entities.Bloco;
using MyCondo.Administracao.Domain.Entities.Morador;
using MyCondo.Administracao.Domain.Entities.VagaGaragem;
using MyCondo.Administracao.Domain.Utils.Enumeradores;
using System.Text.Json.Serialization;

namespace MyCondo.Administracao.Domain.Entities.Apartamento;

public class Apartamentos : BaseEntity
{
    public string Numero { get; protected set; }
    public int Andar { get; protected set; }
    public ETipoApartamento TipoApartamento { get; protected set; }
    public ESimNao PossuiVagasDemarcada { get; protected set; }
    public int TotalVagasDemarcada { get; protected set; } = 0;
    public int BlocosId { get; protected set; }
    [JsonIgnore]
    public Blocos Blocos { get; set; }

    public ICollection<Moradores> Moradores { get; set; }
    public ICollection<VagasGaragem> VagasGaragem { get; set; }

    public Apartamentos()
    {
        SetTotalVagasDemarcada(0);
        SetPossuiVagasDemarcada(ESimNao.Nao);
    }

    public void SetNumero(string numero) => Numero = numero;
    public void SetAndar(int andar) => Andar = andar;
    public void SetTipoApartamento(ETipoApartamento tipoApartamento) => TipoApartamento = tipoApartamento;
    public void SetPossuiVagasDemarcada(ESimNao possuiVagasDemarcada) => PossuiVagasDemarcada = possuiVagasDemarcada;
    public void SetTotalVagasDemarcada(int totalVagasDemarcada) => TotalVagasDemarcada = totalVagasDemarcada;
}

