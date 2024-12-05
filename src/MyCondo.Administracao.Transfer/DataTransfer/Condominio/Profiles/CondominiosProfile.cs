using AutoMapper;
using MyCondo.Administracao.Domain.Entities.Condominio;
using MyCondo.Administracao.Transfer.DataTransfer.Condominio.Request;
using MyCondo.Administracao.Transfer.DataTransfer.Condominio.Response;

namespace MyCondo.Administracao.Transfer.DataTransfer.Condominio.Profiles;

public class CondominiosProfile : Profile
{
    public CondominiosProfile()
    {
        CreateMap<Condominios, CondominiosResponse>().ReverseMap();
        CreateMap<Condominios, CondominiosInserirRequest>().ReverseMap();
        CreateMap<Condominios, CondominiosPesquisaRequest>().ReverseMap();
        CreateMap<Condominios, CondominiosAtualizarRequest>().ReverseMap();
    }
}
