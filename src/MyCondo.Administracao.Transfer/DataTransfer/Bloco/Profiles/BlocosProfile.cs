using AutoMapper;
using MyCondo.Administracao.Domain.Entities.Bloco;
using MyCondo.Administracao.Transfer.DataTransfer.Bloco.Request;
using MyCondo.Administracao.Transfer.DataTransfer.Bloco.Response;

namespace MyCondo.Administracao.Transfer.DataTransfer.Bloco.Profiles;

public class BlocosProfile : Profile
{
    public BlocosProfile()
    {
        CreateMap<Blocos, BlocosAtualizarRequest>().ReverseMap();
        CreateMap<Blocos, BlocosPesquisaRequest>().ReverseMap();
        CreateMap<Blocos, BlocosInserirRequest>().ReverseMap();
        CreateMap<Blocos, BlocosResponse>().ReverseMap();
    }
}
