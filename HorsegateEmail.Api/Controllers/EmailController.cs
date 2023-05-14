using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HorsegateEmail.Api.Domain;
using HorsegateEmail.Api.Service;
using Microsoft.AspNetCore.Mvc;

namespace HorsegateEmail.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService){
            _emailService = emailService;
        }
        [HttpPost]
        public async Task<IActionResult> ReceiveEmail(Messages messages)
        {
            if(!ModelState.IsValid){
                return  BadRequest("Invalid Input");
            }
            var result = _emailService.SendEmailAsync(messages);
            return Ok(result);
        }

        [HttpPost("recieve-admission")]
        public async Task<IActionResult> RecieveAdmission(AdmissionForm admissionForm)
        {
            if(!ModelState.IsValid){
                return BadRequest("Invalid Input");
            }
            var result = _emailService.SendAdmissionAsync(admissionForm);
            return Ok(result);
        }
    }
}