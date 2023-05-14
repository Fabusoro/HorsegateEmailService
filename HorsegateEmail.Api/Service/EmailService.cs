using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using HorsegateEmail.Api.Domain;

namespace HorsegateEmail.Api.Service
{
    public class EmailService : IEmailService
    {
        public async Task<string> SendEmailAsync(Messages messages)
        {
            string senderEmail = "imooluwa0019@gmail.com";
            string senderPassword = "lyyqclasrmvtialw"; // Enter your password here
            string recipientEmail = "imooluwa0019@gmail.com";
            string subject = "Contact Form Submission";
            string body = $"Name: {messages.Name}\nEmail: {messages.Email}\nMessage: {messages.Message}";
            MailMessage message = new MailMessage(senderEmail, recipientEmail, subject, body);
            message.IsBodyHtml = false;

            try{
                using (SmtpClient client = new SmtpClient())
            {
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(senderEmail, senderPassword);
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                client.Send(message);
                return "Message sent successfully";
            }
            }
            catch (Exception ex)
            {
                return "Error " + ex.Message;
            }
        }

         public async Task<string> SendAdmissionAsync(AdmissionForm admission)
        {
            string senderEmail = "imooluwa0019@gmail.com";
            string senderPassword = "lyyqclasrmvtialw"; // Enter your password here
            string recipientEmail = "imooluwa0019@gmail.com";
            string subject = "Admission Form Submission";
            string body = $"FirstName: {admission.FirstName}\nLastName: {admission.LastName}\nEmail: {admission.Email}\nRole: {admission.Role}\nAddress: {admission.Address}\nPhoneNumber: {admission.PhoneNumber}";
            MailMessage message = new MailMessage(senderEmail, recipientEmail, subject, body);
            message.IsBodyHtml = false;

            try{
                using (SmtpClient client = new SmtpClient())
            {
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(senderEmail, senderPassword);
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                client.Send(message);
                return "Message sent successfully";
            }
            }
            catch (Exception ex)
            {
                return "Error " + ex.Message;
            }
        }
    }
}