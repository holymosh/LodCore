﻿using System.Net.Mail;
using Common;
using Journalist;

namespace UserManagement.Domain
{
    public class Account
    {
        public Account(
            string firstname,
            string lastname,
            MailAddress email,
            Password password,
            AccountRole role,
            ConfirmationStatus confirmationStatus,
            Profile profile, 
            int redmineUserId, 
            int gitlabUserId)
        {
            Require.NotEmpty(firstname, nameof(firstname));
            Require.NotEmpty(lastname, nameof(lastname));
            Require.NotNull(email, nameof(email));
            Require.NotNull(password, nameof(password));
            Require.Positive(redmineUserId, nameof(redmineUserId));
            Require.Positive(gitlabUserId, nameof(gitlabUserId));
            Require.NotNull(email, nameof(email));
            Require.NotNull(password, nameof(password));

            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Password = password;
            Role = role;
            ConfirmationStatus = confirmationStatus;
            Profile = profile;
            RedmineUserId = redmineUserId;
            GitlabUserId = gitlabUserId;
        }

        protected Account()
        {
        }

        public virtual int UserId { get; protected set; }

        public virtual string Firstname { get; protected set; }

        public virtual string Lastname { get; protected set; }

        public virtual MailAddress Email { get; protected set; }

        public virtual Password Password { get; protected set; }

        public virtual int RedmineUserId { get; protected set; }

        public virtual int GitlabUserId { get; protected set; }

        public virtual AccountRole Role { get; protected set; }

        public virtual ConfirmationStatus ConfirmationStatus { get; set; }

        public virtual Profile Profile { get; protected set; }
    }
}