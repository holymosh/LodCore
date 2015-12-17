﻿using System.Net.Mail;

namespace UserManagement.Application
{
    public interface IMailer
    {
        void SendConfirmationMail(string confirmationToken, MailAddress email);
    }
}