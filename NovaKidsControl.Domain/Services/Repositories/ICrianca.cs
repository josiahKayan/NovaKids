

using NovaKidsControl.Domain.Entities;
using System;

namespace NovaKidsControl.Domain.Services.Repositories
{
    public interface ICrianca
    {
        Crianca Get(Guid id);
        void Create(Crianca crianca);
        void Update(Crianca crianca);
        void Delete(Crianca crianca);
    }
}
