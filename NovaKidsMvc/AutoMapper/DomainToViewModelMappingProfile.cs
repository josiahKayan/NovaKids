using AutoMapper;
using NovaKidsControl.Domain.Entities;
using NovaKidsMvc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovaKidsMvc.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<UserKidsViewModel, UserKids>();
            Mapper.CreateMap<PresencaViewModel, Presenca>();
        }
    }
}