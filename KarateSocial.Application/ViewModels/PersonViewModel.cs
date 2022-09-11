﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KarateSocial.Application.ViewModels
{
    public class PersonViewModel
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool IsDeleted { get; set; }
        public string FullName { get; set; }
        public string CPF { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
