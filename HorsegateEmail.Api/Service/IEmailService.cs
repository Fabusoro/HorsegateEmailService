using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HorsegateEmail.Api.Domain;

namespace HorsegateEmail.Api.Service
{
    public interface IEmailService
    {
        Task<string> SendEmailAsync(Messages messages);
        Task<string> SendAdmissionAsync(AdmissionForm admission);
    }
}