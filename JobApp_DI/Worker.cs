using System;
using JobApp_DI.Abstractions;
using JobApp_DI.Domain;

namespace JobApp_DI
{
    public class Worker : IWorker
    {
        public Worker(Location loc, Account account)
        {
            _account = account;
        }

        public string Name { get; set; }

        private Account _account;

        internal Location Location { get; private set; }

        public void GoToLocation(Location location)
        {
            Location = location;
        }

        public void DoJob(JobData jobData)
        {
            Console.WriteLine(jobData.Description + " is done.");
        }

        public string GetAccountNumber()
        {
            return _account.Number;
        }
    }
}