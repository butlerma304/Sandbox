using AutoMapper;
using DmgPropertyService.Web.Mapping;

namespace IN.DOT.DamagedProperty.WebUI.Mapping
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