using AutoMapper;
using IN.DOT.DamagedProperty.Api.Domain;
using IN.DOT.DamagedProperty.Api.WebUI.Models;

namespace IN.DOT.DamagedProperty.Api.WebUI.Mapping
{
    public class ViewModelToDomainMappingProfile:Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<CustomerViewModel, Customer>();
        }
    }
}