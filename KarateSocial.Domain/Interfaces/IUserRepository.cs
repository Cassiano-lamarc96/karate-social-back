using System;
using System.Collections.Generic;
using System.Text;
using KarateSocial.Domain.Entities;

namespace KarateSocial.Domain.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        public IEnumerable<User> GetAll();
    }
}
