using KarateSocial.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KarateSocial.Domain.Entities
{
    public class Profile : Entity
    {
        public string Description { get;set; }
        public Guid ProfileGroupId { get; set; }

        public virtual ProfileGroup ProfileGroup { get;set; }
        public virtual ICollection<UserProfile> UserProfiles { get; set; }
    }
}
