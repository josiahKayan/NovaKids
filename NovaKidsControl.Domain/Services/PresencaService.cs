using NovaKidsControl.Domain.Entities;
using NovaKidsControl.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaKidsControl.Domain.Interfaces.Repositories;

namespace NovaKidsControl.Domain.Services
{
    public class PresencaService : ServiceBase<Presenca>, IPresencaService
    {
        private readonly IPresencaRepository _presencaRepository;

        public PresencaService(IPresencaRepository repository) : base(repository)
        {
            _presencaRepository = repository;
        }
    }
}
