using NovaKidsControl.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaKidsControl.Domain.Contracts.Repositories
{
    public interface IProfessor
    {
        Professor Get(Guid id);
        void Create(Professor professor);
        void Update(Professor professor);
        void Delete(Professor professor);
    }
}
