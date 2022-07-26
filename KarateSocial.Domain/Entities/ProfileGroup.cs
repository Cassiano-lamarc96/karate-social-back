using KarateSocial.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KarateSocial.Domain.Entities
{
    public class ProfileGroup : Entity
    {
        public string Description { get; set; }

        public virtual ICollection<Profile> Profiles { get; set; }
    }
}
