﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcGit.Models
{
    public class User
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public int Age { get; set; }
        public List<Skill> Skills { get; set; }
    }
}