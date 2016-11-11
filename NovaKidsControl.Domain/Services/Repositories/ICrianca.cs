using NovaKidsControl.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaKidsControl.Domain.Contracts.Repositories
{
    public interface ICrianca
    {
        Crianca Get(Guid id);
        void Create(Crianca crianca);
        void Update(Crianca crianca);
        void Delete(Crianca crianca);
    }
}
