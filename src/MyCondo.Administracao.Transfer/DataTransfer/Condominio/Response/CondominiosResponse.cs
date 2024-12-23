using MyCondo.Administracao.Domain.Entities.AreaComun;
using MyCondo.Administracao.Domain.Utils.Enumeradores;
using MyCondo.Administracao.Transfer.DataTransfer.AreaComun.Response;
using MyCondo.Administracao.Transfer.DataTransfer.Base;
using MyCondo.Administracao.Transfer.DataTransfer.Bloco.Response;

namespace MyCondo.Administracao.Transfer.DataTransfer.Condominio.Response;

public class CondominiosResponse : BaseResponse
{
    public virtual string Nome { get; set; }
    public virtual string Cnpj { get; set; }
    public virtual ETipoCondominio TipoCondominio { get; set; } = new ETipoCondominio();
    public virtual string? Logo { get; set; }
    public virtual double AreaTotal { get; set; } = double.MinValue;

    public virtual string? Cep { get; set; }
    public virtual string? Cidade { get; set; }
    public virtual string? Uf { get; set; }
    public virtual string? Bairro { get; set; }
    public virtual string? Logradouro { get; set; }
    public virtual string? Numero { get; set; }
    public virtual string? Complemento { get; set; }

    public virtual ICollection<BlocosResponse> Blocos { get; set; }
    public virtual ICollection<AreaComunsResponse> AreaComuns { get; set; }
}

