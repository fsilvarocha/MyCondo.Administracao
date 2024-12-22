﻿using System.ComponentModel;

namespace MyCondo.Administracao.Domain.Utils.Enumeradores;

public enum ETipoMorador
{
    [Description("Proprietário")]
    Proprietario = 1,
    [Description("Inquilino")]
    Inquilino = 2
}
