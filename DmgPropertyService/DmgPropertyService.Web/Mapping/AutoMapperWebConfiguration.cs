using AutoMapper;
using DmgPropertyService.Domain;
using DmgPropertyService.Web.Models;

namespace DmgPropertyService.Web.Mapping
{
    public static class AutoMapperWebConfiguration
    {
        public static void Configure()
        {

            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    
    }
   
}