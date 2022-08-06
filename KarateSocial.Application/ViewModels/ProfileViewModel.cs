using System;
using System.Collections.Generic;
using System.Text;

namespace KarateSocial.Application.ViewModels
{
    public class ProfileViewModel
    {
        public string Description { get; set; }
        public Guid ProfileGroupId { get; set; }

        public virtual ProfileGroupViewModel ProfileGroup { get; set; }
        public virtual ICollection<UserProfileViewModel> UserProfiles { get; set; }
    }
}
