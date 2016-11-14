using NovaKidsControl.Domain.Entities;
using NovaKidsControl.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaKids.Infra.Data.Repositories
{
    public class UserKidsRepository : RepositoryBase<UserKids>, IUserKidsRepository
    {
        public IEnumerable<UserKids> BuscaCriancaPorNome(string nome)
        {
           return db.Criancas.Where(c => c.Nome == nome);
        }

        public IEnumerable<UserKids> BuscaProfessorPorNome(string nome)
        {
            return db.Professores.Where(p => p.Nome == nome);
        }

        //public void AddCrianca(Crianca crianca)
        //{
        //    db.Criancas.Add(crianca);
        //}

        //public void AddProfessor(Professor professor)
        //{
        //    db.Professores.AddProfessor(professor);
        //}
    }
}
