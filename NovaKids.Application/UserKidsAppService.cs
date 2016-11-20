using NovaKids.Application.Interface;
using NovaKidsControl.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaKidsControl.Domain.Interfaces.Services;

namespace NovaKids.Application
{
    public class UserKidsAppService : AppServiceBase<UserKids>, IUserKidsAppService
    {

        private readonly IUserKidsService _userKids;

        public UserKidsAppService(IUserKidsService serviceBase) : base(serviceBase)
        {
            _userKids = serviceBase;
        }
    }
}
