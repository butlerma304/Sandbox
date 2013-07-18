using AutoMapper;
using DmgPropertyService.Web.Models;
using IN.DOT.DamagedProperty.Api.Domain;
using IN.DOT.DamagedProperty.Api.Domain.Model;

namespace DmgPropertyService.Web.Mapping
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