﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace AM.Core.Domain
{
    //[Owned]
    public class FullName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}