using System;
using System.Threading.Tasks;

namespace Hangfire.Services
{
    public interface ITestJob
    {
        Task TestJob();
    }
}