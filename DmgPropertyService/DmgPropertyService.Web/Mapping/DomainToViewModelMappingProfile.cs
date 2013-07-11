using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using DmgPropertyService.Domain;
using DmgPropertyService.Web.Models;

namespace DmgPropertyService.Web.Mapping
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