using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using IN.DOT.DamagedProperty.Api.Domain;
using IN.DOT.DamagedProperty.Api.Domain.Model;

namespace IN.DOT.DamagedProperty.WebUI.Mapping
{
    public abstract class BaseMapper<T, TU>
        where T : EntityBase
        where TU : DtoBase, new()
    {

        protected IMappingExpression<TU, T> DtoToDomainMapping { get; private set; }

        protected IMappingExpression<T, TU> DomainToDtoMapping { get; private set; }


        protected BaseMapper()
        {

            DomainToDtoMapping = Mapper.CreateMap<T, TU>();



            var mex = Mapper.CreateMap<TU, T>()

                            .ForMember(m => m.ID, m => m.Ignore());



            var refProperties = from p in typeof(T).GetProperties()

                                where p.PropertyType.BaseType == typeof(EntityBase)

                                select p;



            foreach (var prop in refProperties)
            {

                mex.ForMember(prop.Name, m => m.Ignore());

            }



          Mapper.CreateMap<PagedResult<T>, PagedResult<TU>>()

                  .ForMember(m => m.Results, m => m.Ignore());

        }



        public TU MapToDto(T instance)
        {

            if (instance == null)

                return null;



            var dto = new TU();



            Mapper.Map(instance, dto);



            return dto;

        }



        public IList<TU> MapToDtoList(IList<T> list)
        {

            if (list == null)

                return new List<TU>();



            var dtoList = new List<TU>();



            Mapper.Map(list, dtoList);



            return dtoList;

        }



        public PagedResult<TU> MapToDtoPagedResult(PagedResult<T> pagedResult)
        {

            if (pagedResult == null)

                return null;



            var dtoResult = new PagedResult<TU>();

            Mapper.Map(pagedResult, dtoResult);

            Mapper.Map(pagedResult.Results, dtoResult.Results);



            return dtoResult;

        }



        public void MapFromDto(TU dto, T instance)
        {

            Mapper.Map(dto, instance);

        }

    }
}
