using MyCondo.Administracao.Domain.Entities.Base;
using MyCondo.Administracao.Domain.Entities.Bloco;
using MyCondo.Administracao.Domain.Utils.Enumeradores;
using System.ComponentModel;
using static System.Reflection.Metadata.BlobBuilder;

namespace MyCondo.Administracao.Domain.Entities.Condominio;

public class Condominios : BaseEntity
{
    public virtual string Nome { get; protected set; }
    public virtual string Cnpj { get; protected set; }
    public virtual ETipoCondominio TipoCondominio { get; protected set; } = new ETipoCondominio();
    public virtual string? Logo { get; protected set; }
    public virtual decimal AreaTotal { get; protected set; } = decimal.MinValue;

    public virtual string? Cep { get; protected set; }
    public virtual string? Cidade { get; protected set; }
    public virtual string? Uf { get; protected set; }
    public virtual string? Bairro { get; protected set; }
    public virtual string? Logradouro { get; protected set; }
    public virtual string? Numero { get; protected set; }
    public virtual string? Complemento { get; protected set; }
    public virtual ICollection<Blocos> Blocos { get; protected set; }

    public Condominios()
    {
    }

    public void SetNome(string nome) => Nome = nome;
    public void SetCnpj(string cnpj) => Cnpj = cnpj;
    public void SetTipoCondominio(ETipoCondominio tipoCondominio) => TipoCondominio = tipoCondominio;
    public void SetLogo(string logo) => Logo = logo;
    public void SetAreaTotal(decimal areaTotal) => AreaTotal = areaTotal;
    public void SetCep(string cep) => Cep = cep;
    public void SetCidade(string cidade) => Cidade = cidade;
    public void SetUf(string uf) => Uf = uf;
    public void SetBairro(string bairro) => Bairro = bairro;
    public void SetLogradouro(string logradouro) => Logradouro = logradouro;
    public void SetNumero(string numero) => Numero = numero;
    public void SetComplemento(string complemento) => Complemento = complemento;
    public void SetDataAtualizado(DateTime dataAtualizado) => DataAtualizado = dataAtualizado;
}

