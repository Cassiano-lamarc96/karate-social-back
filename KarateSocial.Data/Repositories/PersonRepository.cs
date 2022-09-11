using KarateSocial.Data.Context;
using KarateSocial.Domain.Entities;
using KarateSocial.Domain.Interfaces;

namespace KarateSocial.Data.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(KarateSocialContext context)
            : base(context) { }
    }
}
