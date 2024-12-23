using AutoMapper;
using MyCondo.Administracao.Domain.Entities.AreaComun;
using MyCondo.Administracao.Transfer.DataTransfer.AreaComun.Request;
using MyCondo.Administracao.Transfer.DataTransfer.AreaComun.Response;

namespace MyCondo.Administracao.Transfer.DataTransfer.AreaComun.Profiles;

public class AreaComunsProfile : Profile
{
    public AreaComunsProfile()
    {
        CreateMap<AreaComuns, AreaComunsAtualizarRequest>().ReverseMap();
        CreateMap<AreaComuns, AreaComunsPesquisaRequest>().ReverseMap();
        CreateMap<AreaComuns, AreaComunsInserirRequest>().ReverseMap();
        CreateMap<AreaComuns, AreaComunsResponse>().ReverseMap();
    }
}
