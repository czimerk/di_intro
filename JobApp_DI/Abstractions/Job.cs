using JobApp_DI.Domain;
using System;

namespace JobApp_DI.Abstractions
{
    public abstract class Job
    {
        protected JobData _jobData;

        public Job(JobData data)
        {
            _jobData = data ?? throw new ArgumentNullException(nameof(data));
        }

        public virtual void Execute(IWorker w)
        {
            w.DoJob(this._jobData);
            PayWorker(w.GetAccountNumber());
        }

        private void PayWorker(string number)
        {
            Console.WriteLine($"Millions transferred to {number}");
        }
    }
}
