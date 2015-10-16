﻿using NotificationService;

namespace ProjectManagement.Domain.Events
{
    public class ProjectsEventSink : EventSink
    {
        public ProjectsEventSink(IEventRepository repository, IDistributionPolicyFactory distributionPolicyFactory) 
            : base(repository, distributionPolicyFactory)
        {
        }

        public void SendNewIssueEvent(int projectId, Issue issue)
        {
            var distributionPolicy = DistributionPolicyFactory.GetProjectRelatedPolicy(projectId);
            ConsumeEvent(new NewIssueCreated(issue, projectId, distributionPolicy));
        }

        public void SendNewDeveloperEvent(int projectId, int userId)
        {
            ConsumeEvent(new NewDeveloperOnProject(
                userId, 
                projectId, 
                DistributionPolicyFactory.GetProjectRelatedPolicy(projectId)));
        }

    }
}