﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class CreateExperienceView
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Erfarenhet")]
        public string Name { get; set; }
        [Required]
        public int CvId { get; set; }
    }
    public class EditExperienceView
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Erfarenhet")]
        public string Name { get; set; }
    }
}
