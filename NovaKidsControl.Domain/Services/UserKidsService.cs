
using System;
using System.Collections.Generic;
using NovaKidsControl.Domain.Entities;
using NovaKidsControl.Domain.Interfaces.Repositories;
using NovaKidsControl.Domain.Interfaces.Services;

namespace NovaKidsControl.Domain.Services
{
    public class UserKidsService : ServiceBase<UserKids>, IUserKidsService
    {
        private readonly IUserKidsRepository _userRepository;

        public UserKidsService(IUserKidsRepository repository) : base(repository)
        {
            _userRepository = repository;
        }


        public new void Add(UserKids obj)
        {
            _userRepository.Add(obj);
        }

        public new void Delete(UserKids obj)
        {
            throw new NotImplementedException();
        }

        public new void Update(UserKids obj)
        {
            throw new NotImplementedException();
        }

        IEnumerable<UserKids> IServiceBase<UserKids>.GetAll()
        {
            throw new NotImplementedException();
        }

        UserKids IServiceBase<UserKids>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
