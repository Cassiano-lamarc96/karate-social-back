using System;
using System.Collections.Generic;
using System.Text;

namespace KarateSocial.Application.ViewModels
{
    public class UserProfileViewModel
    {
        public Guid ProfileId { get; set; }
        public Guid UserId { get; set; }

        public virtual UserViewModel User { get; set; }
        public virtual ProfileViewModel Profile { get; set; }
    }
}
