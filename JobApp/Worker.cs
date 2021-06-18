using System;

namespace JobApp
{
    public class Worker
    {
        public Worker(Location loc)
        {
                
        }

        public string Name { get; set; }

        public Account Account { get; internal set; }

        public Location Location { get; private set; }

        internal void GoToLocation(Location location)
        {
            Location = location;
        }

        internal void DoJob(JobData jobData)
        {
            Console.WriteLine(jobData.Description + " is done.");
        }
    }
}