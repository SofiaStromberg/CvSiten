﻿using Data.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Shared.Models
{
    public class CvEditImgView
    {
        public int Id { get; set; }
        public string CurrentPath { get; set; }
        public HttpPostedFileBase Image { get; set; }
    }

    public class CvEditInfoView
    {
        public int Id { get; set; }
        [Display(Name = "Namn")]
        public string Name { get; set; }

        [Display(Name = "Adress")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Privat sida")]
        public bool Private { get; set; }
    }

    public class CvIndexView
    {
        public int Id { get; set; }

        [Display(Name = "Namn")]
        public string Name { get; set; }

        [Display(Name = "Adress")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Privat sida")]
        public bool Private { get; set; }
        [Display(Name = "Personlig bild")]
        public string ImagePath { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string UserName { get; set; }
        public List<Project> ListOfProjects { get; set; }
        public List<Education> ListOfEducations { get; set; }
        public List<Competence> ListOfCompetences { get; set; }
        [Display(Name = "Erfarenheter")]
        public List<Experience> ListOfExperiences { get; set; }
    }
}
