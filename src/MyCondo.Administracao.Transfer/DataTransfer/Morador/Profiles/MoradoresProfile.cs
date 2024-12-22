using AutoMapper;
using MyCondo.Administracao.Domain.Entities.Morador;
using MyCondo.Administracao.Domain.Utils.Extensoes;
using MyCondo.Administracao.Transfer.DataTransfer.Morador.Request;
using MyCondo.Administracao.Transfer.DataTransfer.Morador.Response;

namespace MyCondo.Administracao.Transfer.DataTransfer.Morador.Profiles;

public class MoradoresProfile : Profile
{
    public MoradoresProfile()
    {
        CreateMap<Moradores, MoradoresAtualizarRequest>().ReverseMap();
        CreateMap<Moradores, MoradoresExcluirRequest>().ReverseMap();
        CreateMap<Moradores, MoradoresPesquisaRequest>().ReverseMap();
        CreateMap<Moradores, MoradoresInserirRequest>().ReverseMap();
        CreateMap<Moradores, MoradoresResponse>()
            .ForMember(dest => dest.TipoMoradorDescricao, opt => opt.MapFrom(src => src.TipoMorador.ObterDescriaoEnum()))
            .ReverseMap();
    }
}
