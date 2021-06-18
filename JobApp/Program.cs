using System;

namespace JobApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var loc = new Location() { Longitude = 64.12, Latitude = 14.12 };
            var w = new Worker(loc)
            {
                Name = "John Doe"
            };
            var account = new Account() { Name = w.Name, Number = "11444114-41411414-00000000" };
            w.Account = account;

            var jobData = new JobData() { Description = "important job", Id = 1 };
            var job = new Job(loc, jobData);

            job.Execute(w);
        }
    }
}
