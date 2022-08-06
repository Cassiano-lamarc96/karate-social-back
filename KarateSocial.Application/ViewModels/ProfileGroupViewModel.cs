using System;
using System.Collections.Generic;
using System.Text;

namespace KarateSocial.Application.ViewModels
{
    public class ProfileGroupViewModel
    {
        public string Description { get; set; }

        public virtual ICollection<ProfileViewModel> Profiles { get; set; }
    }
}
