﻿namespace MyCondo.Administracao.Transfer.DataTransfer.Base.Interface;

public interface IPesquisaBase
{
    public int Id { get; set; }
    public Guid Tenante { get; set; }
}
