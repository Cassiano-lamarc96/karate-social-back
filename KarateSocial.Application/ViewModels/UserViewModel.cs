using System;
using System.Collections.Generic;
using System.Text;

namespace KarateSocial.Application.ViewModels
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        public PersonViewModel Person { get; set; }
        public string Email { get; set; }
    }
}
