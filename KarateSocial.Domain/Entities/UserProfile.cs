using KarateSocial.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KarateSocial.Domain.Entities
{
    public class UserProfile : Entity
    {
        public Guid ProfileId { get; set; }
        public Guid UserId { get; set; }

        public virtual User User { get; set; }
        public virtual Profile Profile { get; set; }
    }
}
