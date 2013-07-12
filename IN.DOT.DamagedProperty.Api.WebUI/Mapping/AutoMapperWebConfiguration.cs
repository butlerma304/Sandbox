using AutoMapper;

namespace IN.DOT.DamagedProperty.Api.WebUI.Mapping
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