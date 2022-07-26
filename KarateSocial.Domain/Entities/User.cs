using System;
using System.Collections.Generic;
using KarateSocial.Domain.Models;

namespace KarateSocial.Domain.Entities
{
    public class User : Entity
    {
        public Guid PersonId { get; set; }

        public virtual Person Person { get; set; }
        public virtual ICollection<UserProfile> UserProfiles { get; set; }
    }
}
