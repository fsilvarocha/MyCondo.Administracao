using MyCondo.Administracao.Domain.Entities.Apartamento;
using MyCondo.Administracao.Domain.Entities.Base;
using MyCondo.Administracao.Domain.Utils.Enumeradores;
using System.Text.Json.Serialization;

namespace MyCondo.Administracao.Domain.Entities.Morador;

public class Moradores : BaseEntity
{
    public virtual string Nome { get; protected set; }
    public virtual string? Cpf { get; protected set; }
    public virtual ETipoMorador TipoMorador { get; protected set; }
    public virtual int ApartamentoId { get; protected set; }
    public virtual string Foto { get; protected set; }

    [JsonIgnore]
    public Apartamentos Apartamentos { get; protected set; }

    public Moradores()
    {
    }

    public void SetNome(string nome) => Nome = nome;
    public void SetCpf(string cpf) => Cpf = cpf;
    public void SetTipoMorador(ETipoMorador tipoMorador) => TipoMorador = tipoMorador;
    public void SetFoto(string foto) => Foto = foto;
    public void SetApartamentoId(int apartamentoId) => ApartamentoId = apartamentoId;

}
