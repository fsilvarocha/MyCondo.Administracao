using MyCondo.Administracao.Domain.Entities.Apartamento;
using MyCondo.Administracao.Domain.Entities.Base;
using System.Text.Json.Serialization;

namespace MyCondo.Administracao.Domain.Entities.VagaGaragem;

public class VagasGaragem : BaseEntity
{
    public virtual string Nome { get; protected set; }
    public virtual int ApartamentoId { get; protected set; }
    [JsonIgnore]
    public virtual Apartamentos Apartamentos { get; protected set; }

    public VagasGaragem()
    {
    }

    public void SetNome(string nome) => Nome = nome;
    public void SetApartamentoId(int apartamentoId) => ApartamentoId = apartamentoId;
    public void SetApartamento(Apartamentos apartamento) => Apartamentos = apartamento;
}
