using NovaKidsControl.Domain.Entities;
using System;


namespace NovaKidsControl.Domain.Services.Repositories
{
    public interface IProfessor
    {
        Professor Get(Guid id);
        void Create(Professor professor);
        void Update(Professor professor);
        void Delete(Professor professor);
    }
}
