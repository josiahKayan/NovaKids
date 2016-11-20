using NovaKids.Application.Interface;
using NovaKidsControl.Domain.Entities;
using NovaKidsControl.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaKids.Application
{
   


    public class ProfessorAppService : AppServiceBase<Professor>, IProfessorAppService
    {

        private readonly IProfessorService _professorAppService;

        public ProfessorAppService(IProfessorService serviceBase) : base(serviceBase)
        {
            _professorAppService = serviceBase;
        }
    }

}
