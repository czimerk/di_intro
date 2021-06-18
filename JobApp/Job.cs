using System;
using System.Collections.Generic;
using System.Text;

namespace JobApp
{
    public class Job
    {
        private JobData _jobData;

        public Location Location { get; set; }

        public Job(Location loc, JobData data)
        {
            _jobData = data;
            Location = loc;
        }

        public void Execute(Worker w)
        {
            w.GoToLocation(Location);
            w.DoJob(this._jobData);
            PayWorker(w.Account.Number);
        }

        private void PayWorker(string number)
        {
            Console.WriteLine($"Millions transferred to {number}");
        }
    }
}
