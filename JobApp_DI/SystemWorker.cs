using JobApp_DI.Abstractions;
using JobApp_DI.Domain;
using System;

namespace JobApp_DI
{
    public class SystemWorker : IWorker
    {
        public string Name { get; set; }

        private Account _account;

        public SystemWorker(Account account)
        {
            _account = account;
        }

        public void DoJob(JobData jobData)
        {
            Console.WriteLine(jobData.Description + " is done by system job.");
        }

        public string GetAccountNumber()
        {
            return _account.Number;
        }

        public void GoToLocation(Location location)
        {
            return;
        }
    }
}
