﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Jobs_Dashboard_core.Models
{
    public class Job_Type : JobEntity
    {
        [Required]
        public String Job_TypeNme { get; set; }
        public String Job_TypeDesc { get; set; }
    }
}
