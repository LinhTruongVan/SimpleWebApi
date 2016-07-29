using AutoMapper;
using SimpleWebApi.Domain.Entities;
using SimpleWebApi.ViewModels;
using System.Linq;

namespace SimpleWebApi.Infrastructure.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Gadget, GadgetViewModel>()
                .ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id))
                .ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name))
                .ForMember(vm => vm.Description, map => map.MapFrom(m => m.Description))
                .ForMember(vm => vm.Price, map => map.MapFrom(m => m.Price))
              .ForMember(vm => vm.Image, map => map.MapFrom(m => string.IsNullOrEmpty(m.Image) ? "unknown.jpg" : m.Image));

            CreateMap<Category, CategoryViewModel>()
                .ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id))
                .ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name))
                .ForMember(vm => vm.Gadgets,
                    map => map.MapFrom(m => m.Gadgets.Select(Mapper.Map<Gadget, GadgetViewModel>).ToList()));
        }
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }
    }
}