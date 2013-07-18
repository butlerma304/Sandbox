using AutoMapper;
using DmgPropertyService.Web.Models;

namespace IN.DOT.DamagedProperty.WebUI.Mapping
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