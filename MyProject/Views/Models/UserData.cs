﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyProject.Domain.Enums;

namespace MyProject.Models
{
    public class UserData
    {
        public string Username { get; set; }

        public List<string> Products { get; set; }

        public string SingleProduct { get; set; }
    }
}