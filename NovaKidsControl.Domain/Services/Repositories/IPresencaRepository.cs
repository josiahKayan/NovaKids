using NovaKidsControl.Domain.Entities;
using System;

namespace NovaKidsControl.Domain.Services.Repositories
{ 
    public interface IPresencaRepository
    {
        Presenca Get( Guid id );
        void Create(Presenca presenca);
        void Update(Presenca presenca);
        void Delete(Presenca presenca);
    }
}
