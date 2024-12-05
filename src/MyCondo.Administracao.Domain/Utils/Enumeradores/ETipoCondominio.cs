using System.ComponentModel;

namespace MyCondo.Administracao.Domain.Utils.Enumeradores;

public enum ETipoCondominio
{
    [Description("Residencial")]
    Residencial = 0,
    [Description("Comercial")]
    Comercial = 1,
    [Description("Residencial e Comercial")]
    ResidencialComercial = 2
}
