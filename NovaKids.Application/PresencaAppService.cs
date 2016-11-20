


using NovaKids.Application.Interface;
using NovaKidsControl.Domain.Entities;
using NovaKidsControl.Domain.Interfaces.Services;

namespace NovaKids.Application
{
    public class PresencaAppService : AppServiceBase<Presenca>, IPresencaAppService
    {

        private readonly IPresencaService _presencaAppService;

        public PresencaAppService(IPresencaService serviceBase) : base(serviceBase)
        {
            _presencaAppService = serviceBase;
        }
    }
}
