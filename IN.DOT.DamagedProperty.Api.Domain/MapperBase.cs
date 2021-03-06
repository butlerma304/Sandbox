﻿using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using IN.DOT.DamagedProperty.Api.Domain;

namespace DmgPropertyService.Domain
{
    public abstract class BaseMapper<T, U>
        where T : EntityBase
        where U : BaseDto, new()
    {

        protected IMappingExpression<U, T> DtoToDomainMapping { get; private set; }

        protected IMappingExpression<T, U> DomainToDtoMapping { get; private set; }


        protected BaseMapper()
        {

            DomainToDtoMapping = Mapper.CreateMap<T, U>();



            var mex = Mapper.CreateMap<U, T>()

                            .ForMember(m => m.Id, m => m.Ignore());



            var refProperties = from p in typeof(T).GetProperties()

                                where p.PropertyType.BaseType == typeof(EntityBase)

                                select p;



            foreach (var prop in refProperties)
            {

                mex.ForMember(prop.Name, m => m.Ignore());

            }



           <PagedResult<T>, PagedResult<U>>()

                  .ForMember(m => m.Results, m => m.Ignore());

        }



        public U MapToDto(T instance)
        {

            if (instance == null)

                return null;



            var dto = new U();



            Mapper.Map(instance, dto);



            return dto;

        }



        public IList<U> MapToDtoList(IList<T> list)
        {

            if (list == null)

                return new List<U>();



            var dtoList = new List<U>();



            Mapper.Map(list, dtoList);



            return dtoList;

        }



        public PagedResult<U> MapToDtoPagedResult(PagedResult<T> pagedResult)
        {

            if (pagedResult == null)

                return null;



            var dtoResult = new PagedResult<U>();

            Mapper.Map(pagedResult, dtoResult);

            Mapper.Map(pagedResult.Results, dtoResult.Results);



            return dtoResult;

        }



        public void MapFromDto(U dto, T instance)
        {

            Mapper.Map(dto, instance);

        }

    }
}
