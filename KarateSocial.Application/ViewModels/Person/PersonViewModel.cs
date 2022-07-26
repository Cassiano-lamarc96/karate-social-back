﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KarateSocial.Application.ViewModels.Person
{
    public class PersonViewModel
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public DateTime BirthDate { get; set; }
        public string CPF { get; set; }
    }
}
