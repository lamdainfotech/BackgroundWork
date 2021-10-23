using System;
using System.Threading.Tasks;
using Hangfire.Dtos;

namespace Hangfire.Services
{
    public class DoJob : ITestJob
    {
        private readonly IEmailSender _email;

        public DoJob(IEmailSender email)
        {
            _email = email;
        }

        public async Task TestJob()
        {
            var message = new Message(new string[]
           {"dgfool@hotmail.com", "manojregmi22@gmail.com", "tapansharm59@outlook.com"}, "Test Email async", "This is an test email async by Tapan", null);

            await _email.SendEmailAsync(message);
        }
    }
}