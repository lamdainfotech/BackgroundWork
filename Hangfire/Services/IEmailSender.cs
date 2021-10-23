using System.Threading.Tasks;
using Hangfire.Dtos;

namespace Hangfire.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(Message message);
        Task SendMail();
    }
}