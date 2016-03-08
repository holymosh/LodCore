﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;
using Common;
using ProjectManagement.Domain;

namespace FrontendServices.Models
{
    public class CreateProjectRequest
    {
        [MaxLength(25)]
        [Required]
        public string Name { get; set; }

        [Required]
        public ProjectType[] ProjectTypes { get; set; }

        [MaxLength(500)]
        public string Info { get; set; }

        [Required]
        public AccessLevel AccessLevel { get; set; }

        [Required]
        public ProjectStatus ProjectStatus { get; set; }
        
        public Uri LandingImageUri { get; set; }

        public Uri[] Screenshots { get; set; }
    }
}