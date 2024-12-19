using AutoMapper;
using MyCondo.Administracao.Domain.Entities.Apartamento;
using MyCondo.Administracao.Domain.Utils.Extensoes;
using MyCondo.Administracao.Transfer.DataTransfer.Apartamento.Request;
using MyCondo.Administracao.Transfer.DataTransfer.Apartamento.Response;

namespace MyCondo.Administracao.Transfer.DataTransfer.Apartamento.Profiles;

public class ApartamentoProfile : Profile
{
    public ApartamentoProfile()
    {
        CreateMap<Apartamentos, ApartamentosAtualizarRequest>().ReverseMap();
        CreateMap<Apartamentos, ApartamentosExcluirRequest>().ReverseMap();
        CreateMap<Apartamentos, ApartamentosInserirRequest>().ReverseMap();
        CreateMap<Apartamentos, ApartamentosPesquisaRequest>().ReverseMap();
        CreateMap<Apartamentos, ApartamentosResponse>()
            .ForMember(dest => dest.TipoApartamentoDescricao, opt => opt.MapFrom(src => src.TipoApartamento.ObterDescriaoEnum()))
            .ReverseMap();
    }
}
