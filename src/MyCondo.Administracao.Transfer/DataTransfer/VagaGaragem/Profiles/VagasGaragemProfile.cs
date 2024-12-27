using AutoMapper;
using MyCondo.Administracao.Domain.Entities.VagaGaragem;
using MyCondo.Administracao.Domain.Interface.VagaGaragem;
using MyCondo.Administracao.Transfer.DataTransfer.VagaGaragem.Request;
using MyCondo.Administracao.Transfer.DataTransfer.VagaGaragem.Response;

namespace MyCondo.Administracao.Transfer.DataTransfer.VagaGaragem.Profiles;

public class VagasGaragemProfile : Profile
{
    public VagasGaragemProfile()
    {
        CreateMap<VagasGaragem, VagasGaragemAtualizarRequest>().ReverseMap();
        CreateMap<VagasGaragem, VagasGaragemExcluirRequest>().ReverseMap();
        CreateMap<VagasGaragem, VagasGaragemInserirRequest>().ReverseMap();
        CreateMap<VagasGaragem, VagasGaragemPesquisaRequest>().ReverseMap();
        CreateMap<VagasGaragem, VagasGaragemResponse>();
    }
}
