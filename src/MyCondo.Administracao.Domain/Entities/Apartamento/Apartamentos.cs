using MyCondo.Administracao.Domain.Entities.Base;
using MyCondo.Administracao.Domain.Entities.Bloco;
using MyCondo.Administracao.Domain.Entities.Morador;
using MyCondo.Administracao.Domain.Utils.Enumeradores;
using System.Text.Json.Serialization;

namespace MyCondo.Administracao.Domain.Entities.Apartamento;

public class Apartamentos : BaseEntity
{
    public string Numero { get; protected set; }
    public int Andar { get; protected set; }
    public ETipoApartamento TipoApartamento { get; protected set; }
    public int BlocosId { get; protected set; }
    [JsonIgnore]
    public Blocos Blocos { get; set; }

    public ICollection<Moradores> Moradores { get; set; }

    public Apartamentos()
    {
    }

    public void SetNumero(string numero) => Numero = numero;
    public void SetAndar(int andar) => Andar = andar;
    public void SetTipoApartamento(ETipoApartamento tipoApartamento) => TipoApartamento = tipoApartamento;
}

