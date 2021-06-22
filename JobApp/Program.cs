using System;
using System.Collections.Generic;

namespace JobApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var loc = new Location() { Longitude = 64.12, Latitude = 14.12 };
            var locWorker = new Location() { Longitude = 64.22, Latitude = 12.23 };
            var w = new Worker(locWorker)
            {
                Name = "John Doe"
            };
            var account = new Account() { Name = w.Name, Number = "11444114-41411414-00000000" };
            w.Account = account;
            
            var jobData = new JobData() { Description = "important job", Id = 1 };
            var jobData2 = new JobData() { Description = "remote job", Id = 2 };
            Job job = new OnSiteJob(loc, jobData);
            Job job2 = new RemoteJob(locWorker, jobData2);


            var jobs = new List<Job> { job, job2 };
            foreach (var j in jobs)
            {
                j.Execute(w);
            }
        }
    }
}
