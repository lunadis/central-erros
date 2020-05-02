using AutoMapper;
using CentralErros.Application.ViewModel;
using CentralErros.Domain.Models;

namespace CentralErros.Application.Mapper
{
    public class AutoMapperConfig : Profile
    {
        public static MapperConfiguration RegisterMapper()
        {
            return new MapperConfiguration(x => x.AllowNullCollections = true);
        }
        public AutoMapperConfig()
        {
            CreateMap<Aplicacao, AplicacaoViewModel>().ReverseMap();
            CreateMap<Aviso, AvisoViewModel>().ReverseMap();
            CreateMap<Log, LogViewModel>().ReverseMap();
            CreateMap<TipoLog, TipoLogViewModel>().ReverseMap();
            CreateMap<Usuario, UsuarioViewModel>().ReverseMap();
            CreateMap<UsuarioAplicacao, UsuarioAplicacaoViewModel>().ReverseMap();
            CreateMap<UsuarioAviso, UsuarioAvisoViewModel>().ReverseMap();
        }
    }
}
