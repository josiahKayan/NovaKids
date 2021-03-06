﻿using AutoMapper;
using NovaKidsControl.Domain.Entities;
using NovaKidsMvc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovaKidsMvc.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {

        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<UserKids, UserKidsViewModel>();
            Mapper.CreateMap<Presenca, PresencaViewModel>();
        }

    } 
}