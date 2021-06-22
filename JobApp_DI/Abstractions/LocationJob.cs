using JobApp_DI.Domain;
using System;

namespace JobApp_DI.Abstractions
{
    public abstract class LocationJob : Job
    {

        public Location Location { get; set; }

        public LocationJob(Location loc, JobData data) : base(data)
        {
            Location = loc ?? throw new ArgumentNullException(nameof(loc));
        }

        public override void Execute(IWorker w)
        {
            w.GoToLocation(Location);
            base.Execute(w);
        }

        private void PayWorker(string number)
        {
            Console.WriteLine($"Millions transferred to {number}");
        }
    }
}
