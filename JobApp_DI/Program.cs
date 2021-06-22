using JobApp_DI.Abstractions;
using JobApp_DI.Domain;
using System;
using System.Collections.Generic;

namespace JobApp_DI
{
    class Program
    {
        static void Main(string[] args)
        {
            var loc = new Location() { Longitude = 64.12, Latitude = 14.12 };
            var locWorker = new Location() { Longitude = 64.22, Latitude = 12.23 };

            var workerName = "John Doe";
            var account = new Account() { Name = workerName, Number = "11444114-41411414-00000000" };

            var w = new Worker(locWorker, account)
            {
                Name = workerName
            };
            
            var jobData = new JobData() { Description = "important job", Id = 1 };
            var jobData2 = new JobData() { Description = "remote job", Id = 2 };

            Job job = new OnSiteJob(loc, jobData);
            Job job2 = new RemoteJob(locWorker, jobData2);

            var systemName = "External inc.";

            var account2 = new Account() { Name = systemName, Number = "99999999-88888888-00000000" };

            
            var systemWorker = new SystemWorker(account2)
            {
                Name = systemName
            };
            var jobData3 = new JobData() { Description = "system job", Id = 3 };

            Job systemJob = new AutomaticSystemJob(jobData3);
            
            var jobs = new List<Job> { job, job2 };
            foreach (var j in jobs)
            {
                j.Execute(w);
            }

            job.Execute(systemWorker);
        }
    }
}
