﻿using Journalist;
using NotificationService;

namespace UserManagement.Domain.Events
{
    public class NewFullConfirmedDeveloper : EventInfoBase
    {
        public NewFullConfirmedDeveloper(int userId)
        {
            Require.Positive(userId, nameof(userId));

            NewDeveloperId = userId;
        }

        public int NewDeveloperId { get; private set; }
    }
}