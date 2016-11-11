using NovaKidsControl.Domain.Models;
using System;

namespace NovaKidsControl.Domain.Contracts.Repositories
{
    public interface IPresencaRepository
    {
        Presenca Get( Guid id );
        void Create(Presenca presenca);
        void Update(Presenca presenca);
        void Delete(Presenca presenca);
    }
}
