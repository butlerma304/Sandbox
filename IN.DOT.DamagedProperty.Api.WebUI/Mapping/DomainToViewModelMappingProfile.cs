using AutoMapper;
using IN.DOT.DamagedProperty.Api.Domain;
using IN.DOT.DamagedProperty.Api.WebUI.Models;

namespace IN.DOT.DamagedProperty.Api.WebUI.Mapping
{
    public class DomainToViewModelMappingProfile:Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Customer, CustomerViewModel>();
        }
    }
}