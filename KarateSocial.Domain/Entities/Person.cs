using KarateSocial.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KarateSocial.Domain.Entities
{
    public class Person : Entity
    {
        public string FullName { get; set; }
        public string CPF { get; set; }
        public DateTime BirthDate { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
