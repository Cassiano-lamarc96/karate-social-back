using System;
using System.Collections.Generic;
using System.Text;
using KarateSocial.Data.Context;
using KarateSocial.Domain.Entities;
using KarateSocial.Domain.Interfaces;

namespace KarateSocial.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(KarateSocialContext context)
            :base (context) { }

        public IEnumerable<User> GetAll()
        {
            return Query(x => !x.IsDeleted);
        }
    }
}
