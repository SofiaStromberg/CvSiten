﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class ProjectCreate
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime AddedDate { get; set; }
        // public string UserName { get; set; }
    }
}