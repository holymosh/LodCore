﻿using System;
using Journalist;
using ProjectManagement.Domain;

namespace FrontendServices.Models
{
    public class DeveloperPageProjectPreview
    {
        public DeveloperPageProjectPreview(
            int projectId,
            Uri photoUri,
            string name,
            ProjectStatus projectStatus,
            string developerRole)
        {
            Require.Positive(projectId, nameof(projectId));
            Require.NotEmpty(name, nameof(name));
            Require.NotNull(developerRole, nameof(developerRole));

            ProjectId = projectId;
            PhotoUri = photoUri;
            Name = name;
            ProjectStatus = projectStatus;
            DeveloperRole = developerRole;
        }

        public int ProjectId { get; private set; }

        public Uri PhotoUri { get; private set; }

        public string Name { get; private set; }

        public ProjectStatus ProjectStatus { get; private set; }

        public string DeveloperRole { get; private set; }
    }
}