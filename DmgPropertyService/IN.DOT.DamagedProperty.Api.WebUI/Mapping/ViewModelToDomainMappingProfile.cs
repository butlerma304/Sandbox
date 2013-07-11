using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using DmgPropertyService.Domain;
using DmgPropertyService.Web.Models;

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